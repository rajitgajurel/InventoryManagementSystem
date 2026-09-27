using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.Forms
{
    // Main window with a side menu, each screen opens inside the content area
    public partial class MainForm : Form
    {
        private ProductData productData = new ProductData();
        private ReportService reportService = new ReportService();
        private StockMovementData movementData = new StockMovementData();

        // The screen that is open right now (null when Home is showing)
        private Form currentPage = null;

        // Sidebar colours
        private Color menuColour = Color.FromArgb(24, 44, 66);
        private Color activeColour = Color.FromArgb(0, 123, 255);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowHome();
        }

        // Home page with the low stock warning and quick totals
        private void ShowHome()
        {
            ClosePage();
            pnlHome.Visible = true;
            SetActiveButton(btnHome);
            lblSubtitle.Text = "Home";

            ShowLowStockWarning();
            ShowTotals();
            ShowRecentChanges();
        }

        // Opens a screen inside the content area instead of a new window
        private void OpenPage(Form page, Button button, string title)
        {
            ClosePage();
            pnlHome.Visible = false;

            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;

            // Fill the whole content area, scroll bars only show if the window gets too small
            page.AutoScroll = true;
            page.AutoScrollMinSize = page.ClientSize;
            page.Dock = DockStyle.Fill;
            page.FormClosed += Page_FormClosed;
            pnlContent.Controls.Add(page);
            page.Show();

            currentPage = page;
            SetActiveButton(button);
            lblSubtitle.Text = "Home  >  " + title;
        }

        private void ClosePage()
        {
            if (currentPage != null)
            {
                Form page = currentPage;
                currentPage = null;
                page.FormClosed -= Page_FormClosed;
                page.Close();
            }
        }

        // A screen's own Close button takes the user back to Home
        private void Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentPage = null;
            ShowHome();
        }

        // Spreads the four total boxes across the full width of the home page
        private void pnlHome_Resize(object sender, EventArgs e)
        {
            Label[] boxes = { lblStatProducts, lblStatUnits, lblStatValue, lblStatLowStock };
            int gap = 16;
            int width = (pnlHome.ClientSize.Width - 60 - gap * 3) / 4;
            if (width < 150)
            {
                width = 150;
            }

            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Left = 30 + i * (width + gap);
                boxes[i].Width = width;
            }
        }

        // Shows the last 15 stock changes on the home page
        private void ShowRecentChanges()
        {
            try
            {
                List<StockMovement> movements = movementData.GetAll();
                dgvRecent.Rows.Clear();

                for (int i = 0; i < movements.Count && i < 15; i++)
                {
                    StockMovement movement = movements[i];
                    dgvRecent.Rows.Add(movement.MovementDate.ToString("dd/MM/yyyy HH:mm"), movement.ProductName,
                        movement.MovementType, movement.GetQuantityChange(), movement.Note);
                }
                dgvRecent.ClearSelection();
            }
            catch
            {
                // The low stock box above already shows the database error
                dgvRecent.Rows.Clear();
            }
        }

        // Stock in is green and stock out is red
        private void dgvRecent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string columnName = dgvRecent.Columns[e.ColumnIndex].Name;
            if (columnName != "colType" && columnName != "colChange")
            {
                return;
            }

            object type = dgvRecent.Rows[e.RowIndex].Cells["colType"].Value;
            if (type != null && type.ToString() == "IN")
            {
                e.CellStyle.ForeColor = Color.ForestGreen;
            }
            else
            {
                e.CellStyle.ForeColor = Color.DarkRed;
            }
        }

        // Highlights the menu button of the screen that is open
        private void SetActiveButton(Button active)
        {
            Button[] buttons = { btnHome, btnProducts, btnCategories, btnStockMovement, btnRestock, btnHistory, btnReport };
            foreach (Button button in buttons)
            {
                button.BackColor = menuColour;
            }
            active.BackColor = activeColour;
        }

        // Shows how many products need restocking at the top of the home page
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
                lblLowStock.Text = "Could not check stock levels. " + DatabaseHelper.GetFriendlyMessage(ex);
            }
        }

        // Quick totals in the boxes on the home page
        private void ShowTotals()
        {
            try
            {
                StockSummary summary = reportService.GetStockSummary();
                lblStatProducts.Text = "Products\n" + summary.ProductCount;
                lblStatUnits.Text = "Units in Stock\n" + summary.TotalUnits;
                lblStatValue.Text = "Stock Value\n$" + summary.TotalValue.ToString("N2");
                lblStatLowStock.Text = "Low Stock\n" + summary.LowStockCount;

                if (summary.LowStockCount > 0)
                {
                    lblStatLowStock.BackColor = Color.MistyRose;
                    lblStatLowStock.ForeColor = Color.DarkRed;
                }
                else
                {
                    lblStatLowStock.BackColor = Color.White;
                    lblStatLowStock.ForeColor = Color.FromArgb(33, 64, 95);
                }
            }
            catch
            {
                // The low stock box above already shows the database error
                lblStatProducts.Text = "Products\n-";
                lblStatUnits.Text = "Units in Stock\n-";
                lblStatValue.Text = "Stock Value\n-";
                lblStatLowStock.Text = "Low Stock\n-";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHome();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenPage(new ProductForm(), btnProducts, "Products");
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenPage(new CategoryForm(), btnCategories, "Categories");
        }

        private void btnStockMovement_Click(object sender, EventArgs e)
        {
            OpenPage(new StockMovementForm(), btnStockMovement, "Stock In / Out");
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            OpenPage(new RestockForm(), btnRestock, "Restock List");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenPage(new HistoryForm(), btnHistory, "Stock History");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenPage(new ReportForm(), btnReport, "Stock Report");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
