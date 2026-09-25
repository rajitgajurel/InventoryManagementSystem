using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms
{
    // Shows the stock in and stock out history, for all products or one product
    public partial class HistoryForm : Form
    {
        private ProductData productData = new ProductData();
        private StockMovementData movementData = new StockMovementData();

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadHistory();
        }

        // First item is "All products", then every product
        private void LoadProducts()
        {
            try
            {
                cboProduct.Items.Clear();
                cboProduct.Items.Add("All products");

                List<Product> products = productData.GetAll();
                foreach (Product product in products)
                {
                    cboProduct.Items.Add(product);
                }

                // Stop the SelectedIndexChanged event loading the history twice
                cboProduct.SelectedIndexChanged -= cboProduct_SelectedIndexChanged;
                cboProduct.SelectedIndex = 0;
                cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the products.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHistory()
        {
            try
            {
                List<StockMovement> movements;
                Product product = cboProduct.SelectedItem as Product;

                if (product == null)
                {
                    movements = movementData.GetAll();
                }
                else
                {
                    movements = movementData.GetByProduct(product.Id);
                }

                dgvHistory.Rows.Clear();

                int unitsIn = 0;
                int unitsOut = 0;
                foreach (StockMovement movement in movements)
                {
                    dgvHistory.Rows.Add(movement.MovementDate.ToString("dd/MM/yyyy HH:mm"), movement.ProductName,
                        movement.MovementType, movement.GetQuantityChange(), movement.Note);

                    if (movement.MovementType == "IN")
                    {
                        unitsIn += movement.Quantity;
                    }
                    else
                    {
                        unitsOut += movement.Quantity;
                    }
                }
                dgvHistory.ClearSelection();

                if (movements.Count == 0)
                {
                    lblCount.Text = "No stock movements found.";
                }
                else
                {
                    lblCount.Text = "Movements: " + movements.Count + "     Units in: " + unitsIn + "     Units out: " + unitsOut;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the stock history.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }

        // Stock in is green and stock out is red in the Type and Change columns
        private void dgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string columnName = dgvHistory.Columns[e.ColumnIndex].Name;
            if (columnName != "colType" && columnName != "colChange")
            {
                return;
            }

            object type = dgvHistory.Rows[e.RowIndex].Cells["colType"].Value;
            if (type != null && type.ToString() == "IN")
            {
                e.CellStyle.ForeColor = Color.ForestGreen;
            }
            else
            {
                e.CellStyle.ForeColor = Color.DarkRed;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
