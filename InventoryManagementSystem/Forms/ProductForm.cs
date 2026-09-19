using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Forms
{
    public partial class ProductForm : Form
    {
        private ProductData productData = new ProductData();
        private CategoryData categoryData = new CategoryData();

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

                lblCount.Text = "Total products: " + products.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Builds a Product from the text boxes, throws if something is missing or not a number
        private Product ReadInputs()
        {
            if (txtCode.Text.Trim() == "" || txtName.Text.Trim() == "")
            {
                throw new Exception("Product code and name are required.");
            }
            if (cboCategory.SelectedItem == null)
            {
                throw new Exception("Please choose a category.");
            }

            decimal price;
            int quantity;
            int minLevel;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price))
            {
                throw new Exception("Unit price must be a number.");
            }
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                throw new Exception("Quantity must be a whole number.");
            }
            if (!int.TryParse(txtMinLevel.Text.Trim(), out minLevel))
            {
                throw new Exception("Min stock level must be a whole number.");
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
            return product;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
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
