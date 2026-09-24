using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms
{
    // Shows the products that are at or below their minimum stock level
    public partial class RestockForm : Form
    {
        private ProductData productData = new ProductData();

        public RestockForm()
        {
            InitializeComponent();
        }

        private void RestockForm_Load(object sender, EventArgs e)
        {
            LoadRestockList();
        }

        private void LoadRestockList()
        {
            try
            {
                List<Product> products = productData.GetLowStock();
                dgvRestock.Rows.Clear();

                int totalToOrder = 0;
                foreach (Product product in products)
                {
                    int amount = product.GetRestockAmount();
                    totalToOrder += amount;
                    dgvRestock.Rows.Add(product.Code, product.Name, product.CategoryName,
                        product.Quantity, product.MinStockLevel, amount);
                }
                dgvRestock.ClearSelection();

                if (products.Count == 0)
                {
                    lblCount.Text = "No products need restocking. All stock is above the minimum level.";
                }
                else
                {
                    lblCount.Text = "Products to restock: " + products.Count + "     Total units to order: " + totalToOrder;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the restock list.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Out of stock rows are shown in red so they stand out
        private void dgvRestock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object quantity = dgvRestock.Rows[e.RowIndex].Cells["colQuantity"].Value;
            if (quantity != null && (int)quantity == 0)
            {
                e.CellStyle.BackColor = Color.MistyRose;
                e.CellStyle.ForeColor = Color.DarkRed;
                e.CellStyle.SelectionBackColor = Color.IndianRed;
                e.CellStyle.SelectionForeColor = Color.White;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRestockList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
