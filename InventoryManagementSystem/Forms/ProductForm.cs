using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Validation;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private ProductData productData = new ProductData();
        private CategoryData categoryData = new CategoryData();

        // Id of the product picked in the grid, 0 means nothing selected
        private int selectedId = 0;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        // Fills the category drop down
        private void LoadCategories()
        {
            try
            {
                // ValueMember lets the grid click pick the category by its id
                cboCategory.ValueMember = "Id";
                cboCategory.DataSource = categoryData.GetAll();
                cboCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load categories.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                List<Product> products = productData.GetAll();
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                // Nicer column headings and widths
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["Id"].HeaderText = "ID";
                dgvProducts.Columns["Id"].FillWeight = 8;
                dgvProducts.Columns["Code"].FillWeight = 14;
                dgvProducts.Columns["Name"].HeaderText = "Product Name";
                dgvProducts.Columns["Name"].FillWeight = 28;
                dgvProducts.Columns["CategoryName"].HeaderText = "Category";
                dgvProducts.Columns["CategoryName"].FillWeight = 18;
                dgvProducts.Columns["UnitPrice"].HeaderText = "Unit Price";
                dgvProducts.Columns["UnitPrice"].FillWeight = 12;
                dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
                dgvProducts.Columns["Quantity"].HeaderText = "Qty";
                dgvProducts.Columns["Quantity"].FillWeight = 9;
                dgvProducts.Columns["MinStockLevel"].HeaderText = "Min Level";
                dgvProducts.Columns["MinStockLevel"].FillWeight = 11;
                dgvProducts.ClearSelection();

                // Count how many are low so the user can see it under the list
                int lowCount = 0;
                foreach (Product product in products)
                {
                    if (product.IsLowStock())
                    {
                        lowCount++;
                    }
                }
                lblCount.Text = "Total products: " + products.Count + "     Low stock (shown in red): " + lowCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Colours low stock rows red each time a cell is drawn
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Product product = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            if (product != null && product.IsLowStock())
            {
                e.CellStyle.BackColor = Color.MistyRose;
                e.CellStyle.ForeColor = Color.DarkRed;
                e.CellStyle.SelectionBackColor = Color.IndianRed;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        // Puts the clicked row into the input boxes
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Product product = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            selectedId = product.Id;
            txtCode.Text = product.Code;
            txtName.Text = product.Name;
            txtPrice.Text = product.UnitPrice.ToString("0.00");
            txtQuantity.Text = product.Quantity.ToString();
            txtMinLevel.Text = product.MinStockLevel.ToString();
            cboCategory.SelectedValue = product.CategoryId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = ReadInputs();

                if (productData.CodeExists(product.Code, 0))
                {
                    MessageBox.Show("A product with this code already exists.", "Duplicate Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                productData.Add(product);
                MessageBox.Show("Product added.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadProducts();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Product product = ReadInputs();
                product.Id = selectedId;

                // Another product may already use the new code
                if (productData.CodeExists(product.Code, selectedId))
                {
                    MessageBox.Show("A product with this code already exists.", "Duplicate Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                productData.Update(product);
                MessageBox.Show("Product updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadProducts();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult answer = MessageBox.Show("Delete product '" + txtName.Text + "'?\nIts stock history will be deleted too.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                productData.Delete(selectedId);
                ClearInputs();
                LoadProducts();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Builds a Product from the text boxes, throws if something is missing or not a number
        private Product ReadInputs()
        {
            if (txtCode.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                throw new ValidationException("Product code and name are required.");
            }
            if (cboCategory.SelectedItem == null)
            {
                throw new ValidationException("Please choose a category.");
            }

            decimal price;
            int quantity;
            int minLevel;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                throw new ValidationException("Unit price must be a number.");
            }
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                throw new ValidationException("Quantity must be a whole number.");
            }
            if (!int.TryParse(txtMinLevel.Text.Trim(), out minLevel))
            {
                throw new ValidationException("Min stock level must be a whole number.");
            }

            Category category = (Category)cboCategory.SelectedItem;

            // The Product properties throw if a number is negative
            Product product = new Product();
            product.Code = txtCode.Text.Trim();
            product.Name = txtName.Text.Trim();
            product.CategoryId = category.Id;
            product.UnitPrice = price;
            product.Quantity = quantity;
            product.MinStockLevel = minLevel;

            // Last check before it goes to the database
            product.Validate();
            return product;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            selectedId = 0;
            txtCode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtMinLevel.Clear();
            cboCategory.SelectedIndex = -1;
            dgvProducts.ClearSelection();
            txtCode.Focus();
        }
    }
}
