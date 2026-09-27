using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Forms
{
    // Shows the stock summary report worked out by ReportService
    public partial class ReportForm : Form
    {
        private ReportService reportService = new ReportService();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                StockSummary summary = reportService.GetStockSummary();

                lblCreated.Text = "Report made on " + summary.CreatedAt.ToString("dd/MM/yyyy HH:mm");
                lblProducts.Text = "Products\n" + summary.ProductCount;
                lblUnits.Text = "Units in Stock\n" + summary.TotalUnits;
                lblValue.Text = "Stock Value\n$" + summary.TotalValue.ToString("N2");
                lblLowStock.Text = "Low Stock\n" + summary.LowStockCount;
                lblOutOfStock.Text = "Out of Stock\n" + summary.OutOfStockCount;

                // Low stock and out of stock boxes turn red when there is a problem
                SetWarningColour(lblLowStock, summary.LowStockCount > 0);
                SetWarningColour(lblOutOfStock, summary.OutOfStockCount > 0);

                dgvCategories.Rows.Clear();
                foreach (CategorySummary category in summary.Categories)
                {
                    dgvCategories.Rows.Add(category.CategoryName, category.ProductCount, category.TotalUnits,
                        "$" + category.TotalValue.ToString("N2"), category.LowStockCount);
                }

                // Total row at the bottom of the table
                if (summary.Categories.Count > 0)
                {
                    int row = dgvCategories.Rows.Add("TOTAL", summary.ProductCount, summary.TotalUnits,
                        "$" + summary.TotalValue.ToString("N2"), summary.LowStockCount);
                    dgvCategories.Rows[row].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    dgvCategories.Rows[row].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
                dgvCategories.ClearSelection();

                if (summary.ProductCount == 0)
                {
                    lblCount.Text = "There are no products yet. Add products to see the report.";
                }
                else
                {
                    lblCount.Text = "Categories with products: " + summary.Categories.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the stock summary report.\n\n" + DatabaseHelper.GetFriendlyMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetWarningColour(Label label, bool warning)
        {
            if (warning)
            {
                label.BackColor = Color.MistyRose;
                label.ForeColor = Color.DarkRed;
            }
            else
            {
                label.BackColor = Color.White;
                label.ForeColor = Color.FromArgb(33, 64, 95);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
