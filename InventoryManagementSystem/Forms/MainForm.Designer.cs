namespace InventoryManagementSystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolTip = new ToolTip(components);
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlSidebar = new Panel();
            btnHome = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnStockMovement = new Button();
            btnRestock = new Button();
            btnHistory = new Button();
            btnReport = new Button();
            btnExit = new Button();
            pnlContent = new Panel();
            pnlHome = new Panel();
            lblWelcome = new Label();
            lblHint = new Label();
            lblLowStock = new Label();
            lblStatProducts = new Label();
            lblStatUnits = new Label();
            lblStatValue = new Label();
            lblStatLowStock = new Label();
            lblRecent = new Label();
            dgvRecent = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colChange = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(33, 64, 95);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 80);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(424, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(200, 215, 230);
            lblSubtitle.Location = new Point(23, 49);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(52, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Home";
            //
            // pnlSidebar
            //
            pnlSidebar.BackColor = Color.FromArgb(24, 44, 66);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnCategories);
            pnlSidebar.Controls.Add(btnStockMovement);
            pnlSidebar.Controls.Add(btnRestock);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnReport);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 80);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 640);
            pnlSidebar.TabIndex = 1;
            //
            // btnHome
            //
            btnHome.BackColor = Color.FromArgb(24, 44, 66);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 15);
            btnHome.Name = "btnHome";
            toolTip.SetToolTip(btnHome, "Low stock warning, totals and recent stock changes");
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(220, 50);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            //
            // btnProducts
            //
            btnProducts.BackColor = Color.FromArgb(24, 44, 66);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 65);
            btnProducts.Name = "btnProducts";
            toolTip.SetToolTip(btnProducts, "Add, edit, delete and search products");
            btnProducts.Padding = new Padding(20, 0, 0, 0);
            btnProducts.Size = new Size(220, 50);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            //
            // btnCategories
            //
            btnCategories.BackColor = Color.FromArgb(24, 44, 66);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 115);
            btnCategories.Name = "btnCategories";
            toolTip.SetToolTip(btnCategories, "Add, edit and delete categories");
            btnCategories.Padding = new Padding(20, 0, 0, 0);
            btnCategories.Size = new Size(220, 50);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            //
            // btnStockMovement
            //
            btnStockMovement.BackColor = Color.FromArgb(24, 44, 66);
            btnStockMovement.Cursor = Cursors.Hand;
            btnStockMovement.FlatAppearance.BorderSize = 0;
            btnStockMovement.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnStockMovement.FlatStyle = FlatStyle.Flat;
            btnStockMovement.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStockMovement.ForeColor = Color.White;
            btnStockMovement.Location = new Point(0, 165);
            btnStockMovement.Name = "btnStockMovement";
            toolTip.SetToolTip(btnStockMovement, "Record stock coming in or going out");
            btnStockMovement.Padding = new Padding(20, 0, 0, 0);
            btnStockMovement.Size = new Size(220, 50);
            btnStockMovement.TabIndex = 3;
            btnStockMovement.Text = "Stock In / Out";
            btnStockMovement.TextAlign = ContentAlignment.MiddleLeft;
            btnStockMovement.UseVisualStyleBackColor = false;
            btnStockMovement.Click += btnStockMovement_Click;
            //
            // btnRestock
            //
            btnRestock.BackColor = Color.FromArgb(24, 44, 66);
            btnRestock.Cursor = Cursors.Hand;
            btnRestock.FlatAppearance.BorderSize = 0;
            btnRestock.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(0, 215);
            btnRestock.Name = "btnRestock";
            toolTip.SetToolTip(btnRestock, "Products at or below their minimum level");
            btnRestock.Padding = new Padding(20, 0, 0, 0);
            btnRestock.Size = new Size(220, 50);
            btnRestock.TabIndex = 4;
            btnRestock.Text = "Restock List";
            btnRestock.TextAlign = ContentAlignment.MiddleLeft;
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            //
            // btnHistory
            //
            btnHistory.BackColor = Color.FromArgb(24, 44, 66);
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(0, 265);
            btnHistory.Name = "btnHistory";
            toolTip.SetToolTip(btnHistory, "All stock in and stock out records");
            btnHistory.Padding = new Padding(20, 0, 0, 0);
            btnHistory.Size = new Size(220, 50);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "Stock History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            //
            // btnReport
            //
            btnReport.BackColor = Color.FromArgb(24, 44, 66);
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 80, 115);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(0, 315);
            btnReport.Name = "btnReport";
            toolTip.SetToolTip(btnReport, "Stock summary report with totals per category");
            btnReport.Padding = new Padding(20, 0, 0, 0);
            btnReport.Size = new Size(220, 50);
            btnReport.TabIndex = 6;
            btnReport.Text = "Stock Report";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 35, 51);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 590);
            btnExit.Name = "btnExit";
            toolTip.SetToolTip(btnExit, "Close the program");
            btnExit.Size = new Size(220, 50);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // pnlContent
            //
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Controls.Add(pnlHome);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(980, 640);
            pnlContent.TabIndex = 2;
            //
            // pnlHome
            //
            pnlHome.Controls.Add(lblWelcome);
            pnlHome.Controls.Add(lblHint);
            pnlHome.Controls.Add(lblLowStock);
            pnlHome.Controls.Add(lblStatProducts);
            pnlHome.Controls.Add(lblStatUnits);
            pnlHome.Controls.Add(lblStatValue);
            pnlHome.Controls.Add(lblStatLowStock);
            pnlHome.Controls.Add(lblRecent);
            pnlHome.Controls.Add(dgvRecent);
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.Location = new Point(0, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(980, 640);
            pnlHome.TabIndex = 0;
            pnlHome.Resize += pnlHome_Resize;
            //
            // lblWelcome
            //
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(33, 64, 95);
            lblWelcome.Location = new Point(28, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(172, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            //
            // lblHint
            //
            lblHint.AutoSize = true;
            lblHint.Font = new Font("Segoe UI", 10F);
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(30, 62);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(560, 23);
            lblHint.TabIndex = 1;
            lblHint.Text = "Use the menu on the left to manage products, record stock and view reports.";
            //
            // lblLowStock
            //
            lblLowStock.BackColor = Color.FromArgb(233, 236, 239);
            lblLowStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.DimGray;
            lblLowStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLowStock.Location = new Point(30, 100);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Padding = new Padding(10, 0, 10, 0);
            lblLowStock.Size = new Size(920, 50);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "Checking stock levels...";
            lblLowStock.TextAlign = ContentAlignment.MiddleLeft;
            //
            // lblStatProducts
            //
            lblStatProducts.BackColor = Color.White;
            lblStatProducts.BorderStyle = BorderStyle.FixedSingle;
            lblStatProducts.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStatProducts.ForeColor = Color.FromArgb(33, 64, 95);
            lblStatProducts.Location = new Point(30, 170);
            lblStatProducts.Name = "lblStatProducts";
            lblStatProducts.Size = new Size(224, 100);
            lblStatProducts.TabIndex = 3;
            lblStatProducts.Text = "Products\n-";
            lblStatProducts.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatUnits
            //
            lblStatUnits.BackColor = Color.White;
            lblStatUnits.BorderStyle = BorderStyle.FixedSingle;
            lblStatUnits.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStatUnits.ForeColor = Color.FromArgb(33, 64, 95);
            lblStatUnits.Location = new Point(262, 170);
            lblStatUnits.Name = "lblStatUnits";
            lblStatUnits.Size = new Size(224, 100);
            lblStatUnits.TabIndex = 4;
            lblStatUnits.Text = "Units in Stock\n-";
            lblStatUnits.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatValue
            //
            lblStatValue.BackColor = Color.White;
            lblStatValue.BorderStyle = BorderStyle.FixedSingle;
            lblStatValue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStatValue.ForeColor = Color.FromArgb(33, 64, 95);
            lblStatValue.Location = new Point(494, 170);
            lblStatValue.Name = "lblStatValue";
            lblStatValue.Size = new Size(224, 100);
            lblStatValue.TabIndex = 5;
            lblStatValue.Text = "Stock Value\n-";
            lblStatValue.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblStatLowStock
            //
            lblStatLowStock.BackColor = Color.White;
            lblStatLowStock.BorderStyle = BorderStyle.FixedSingle;
            lblStatLowStock.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStatLowStock.ForeColor = Color.FromArgb(33, 64, 95);
            lblStatLowStock.Location = new Point(726, 170);
            lblStatLowStock.Name = "lblStatLowStock";
            lblStatLowStock.Size = new Size(224, 100);
            lblStatLowStock.TabIndex = 6;
            lblStatLowStock.Text = "Low Stock\n-";
            lblStatLowStock.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblRecent
            //
            lblRecent.AutoSize = true;
            lblRecent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecent.ForeColor = Color.FromArgb(33, 64, 95);
            lblRecent.Location = new Point(28, 295);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(210, 28);
            lblRecent.TabIndex = 7;
            lblRecent.Text = "Recent Stock Changes";
            //
            // dgvRecent
            //
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.FixedSingle;
            dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecent.ColumnHeadersHeight = 36;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecent.Columns.AddRange(new DataGridViewColumn[] { colDate, colProduct, colType, colChange, colNote });
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvRecent.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.GridColor = Color.Gainsboro;
            dgvRecent.Location = new Point(30, 330);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.RowTemplate.Height = 32;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(920, 280);
            dgvRecent.TabIndex = 8;
            dgvRecent.CellFormatting += dgvRecent_CellFormatting;
            //
            // colDate
            //
            colDate.FillWeight = 18F;
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            //
            // colProduct
            //
            colProduct.FillWeight = 30F;
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            //
            // colType
            //
            colType.FillWeight = 10F;
            colType.HeaderText = "Type";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.ReadOnly = true;
            //
            // colChange
            //
            colChange.FillWeight = 10F;
            colChange.HeaderText = "Change";
            colChange.MinimumWidth = 6;
            colChange.Name = "colChange";
            colChange.ReadOnly = true;
            //
            // colNote
            //
            colNote.FillWeight = 32F;
            colNote.HeaderText = "Note";
            colNote.MinimumWidth = 6;
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 720);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlHome.ResumeLayout(false);
            pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlSidebar;
        private Button btnHome;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnStockMovement;
        private Button btnRestock;
        private Button btnHistory;
        private Button btnReport;
        private Button btnExit;
        private Panel pnlContent;
        private Panel pnlHome;
        private Label lblWelcome;
        private Label lblHint;
        private Label lblLowStock;
        private Label lblStatProducts;
        private Label lblStatUnits;
        private Label lblStatValue;
        private Label lblStatLowStock;
        private Label lblRecent;
        private DataGridView dgvRecent;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colChange;
        private DataGridViewTextBoxColumn colNote;
    }
}
