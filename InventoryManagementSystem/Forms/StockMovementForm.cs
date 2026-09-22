using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;
using InventoryManagementSystem.Validation;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Forms
{
    // Records stock coming in (deliveries) and going out (sales, damaged items)
    public partial class StockMovementForm : Form
    {
        private ProductData productData = new ProductData();
        private InventoryService inventoryService = new InventoryService();

        public StockMovementForm()
        {
            InitializeComponent();
        }

        private void StockMovementForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // Fills the product drop down and the stock list
        private void LoadProducts()
        {
            try
            {
                List<Product> products = productData.GetAll();

                // The drop down gets its own copy so picking a product does not move the grid
                cboProduct.ValueMember = "Id";
                cboProduct.DataSource = new List<Product>(products);
                cboProduct.SelectedIndex = -1;

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                // Only show the columns that matter for stock
                dgvProducts.Columns["Id"].Visible = false;
                dgvProducts.Columns["CategoryId"].Visible = false;
                dgvProducts.Columns["UnitPrice"].Visible = false;
                dgvProducts.Columns["Code"].FillWeight = 15;
                dgvProducts.Columns["Name"].HeaderText = "Product Name";
                dgvProducts.Columns["Name"].FillWeight = 35;
                dgvProducts.Columns["CategoryName"].HeaderText = "Category";
                dgvProducts.Columns["CategoryName"].FillWeight = 20;
                dgvProducts.Columns["Quantity"].HeaderText = "Qty";
                dgvProducts.Columns["Quantity"].FillWeight = 12;
                dgvProducts.Columns["MinStockLevel"].HeaderText = "Min Level";
                dgvProducts.Columns["MinStockLevel"].FillWeight = 12;
                dgvProducts.ClearSelection();

                lblCount.Text = "Total products: " + products.Count;
                ShowCurrentStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load products.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Shows how many of the chosen product are in stock
        private void ShowCurrentStock()
        {
            Product product = (Product)cboProduct.SelectedItem;
            if (product == null)
            {
                lblCurrentStock.Text = "Current stock: -";
                return;
            }
            lblCurrentStock.Text = "Current stock: " + product.Quantity + "  (min level " + product.MinStockLevel + ")";
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCurrentStock();
        }

        // Clicking a row picks that product in the drop down
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Product product = (Product)dgvProducts.Rows[e.RowIndex].DataBoundItem;
            cboProduct.SelectedValue = product.Id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = (Product)cboProduct.SelectedItem;
                if (product == null)
                {
                    throw new ValidationException("Please choose a product.");
                }

                int quantity;
                if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
                {
                    throw new ValidationException("Quantity must be a whole number.");
                }

                // The service checks the quantity and saves everything in one transaction
                if (rdoStockIn.Checked)
                {
                    inventoryService.AddStock(product.Id, quantity, txtNote.Text);
                    MessageBox.Show(quantity + " added to " + product.Name + ".", "Stock In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    inventoryService.RemoveStock(product.Id, quantity, txtNote.Text);
                    MessageBox.Show(quantity + " taken from " + product.Name + ".", "Stock Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reload so the new quantity shows, and keep the same product picked
                int productId = product.Id;
                LoadProducts();
                cboProduct.SelectedValue = productId;
                txtQuantity.Clear();
                txtNote.Clear();
                txtQuantity.Focus();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the stock movement.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboProduct.SelectedIndex = -1;
            rdoStockIn.Checked = true;
            txtQuantity.Clear();
            txtNote.Clear();
            dgvProducts.ClearSelection();
            cboProduct.Focus();
        }
    }
}
