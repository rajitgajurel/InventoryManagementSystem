using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Forms
{
    // Main menu that opens the other screens
    public partial class MainForm : Form
    {
        private ProductData productData = new ProductData();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowLowStockWarning();
        }

        // Shows how many products need restocking at the top of the menu
        private void ShowLowStockWarning()
        {
            try
            {
                List<Product> lowStock = productData.GetLowStock();

                if (lowStock.Count == 0)
                {
                    lblLowStock.BackColor = Color.FromArgb(212, 237, 218);
                    lblLowStock.ForeColor = Color.FromArgb(21, 87, 36);
                    lblLowStock.Text = "All products are above their minimum stock level.";
                }
                else
                {
                    // List the first few names so the user knows what to restock
                    string names = "";
                    for (int i = 0; i < lowStock.Count && i < 3; i++)
                    {
                        if (names != "")
                        {
                            names += ", ";
                        }
                        names += lowStock[i].Name;
                    }
                    if (lowStock.Count > 3)
                    {
                        names += "...";
                    }

                    lblLowStock.BackColor = Color.FromArgb(248, 215, 218);
                    lblLowStock.ForeColor = Color.FromArgb(114, 28, 36);
                    lblLowStock.Text = "Warning: " + lowStock.Count + " product(s) low on stock - " + names;
                }
            }
            catch (Exception ex)
            {
                lblLowStock.BackColor = Color.FromArgb(255, 243, 205);
                lblLowStock.ForeColor = Color.FromArgb(133, 100, 4);
                lblLowStock.Text = "Could not check stock levels: " + ex.Message;
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
            ShowLowStockWarning();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
            ShowLowStockWarning();
        }

        private void btnStockMovement_Click(object sender, EventArgs e)
        {
            StockMovementForm form = new StockMovementForm();
            form.ShowDialog();
            ShowLowStockWarning();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            RestockForm form = new RestockForm();
            form.ShowDialog();
            ShowLowStockWarning();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
