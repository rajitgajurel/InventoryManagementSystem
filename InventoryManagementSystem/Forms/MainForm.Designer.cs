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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblLowStock = new Label();
            btnProducts = new Button();
            btnCategories = new Button();
            btnStockMovement = new Button();
            btnRestock = new Button();
            btnHistory = new Button();
            btnExit = new Button();
            pnlHeader.SuspendLayout();
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
            pnlHeader.Size = new Size(600, 95);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 12);
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
            lblSubtitle.Location = new Point(28, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(280, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Choose what you want to manage";
            //
            // lblLowStock
            //
            lblLowStock.BackColor = Color.FromArgb(233, 236, 239);
            lblLowStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.DimGray;
            lblLowStock.Location = new Point(40, 112);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Padding = new Padding(10, 0, 10, 0);
            lblLowStock.Size = new Size(520, 50);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "Checking stock levels...";
            lblLowStock.TextAlign = ContentAlignment.MiddleLeft;
            //
            // btnProducts
            //
            btnProducts.BackColor = Color.FromArgb(0, 123, 255);
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(40, 180);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(250, 90);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            //
            // btnCategories
            //
            btnCategories.BackColor = Color.FromArgb(40, 167, 69);
            btnCategories.Cursor = Cursors.Hand;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(310, 180);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(250, 90);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            //
            // btnStockMovement
            //
            btnStockMovement.BackColor = Color.FromArgb(253, 126, 20);
            btnStockMovement.Cursor = Cursors.Hand;
            btnStockMovement.FlatAppearance.BorderSize = 0;
            btnStockMovement.FlatStyle = FlatStyle.Flat;
            btnStockMovement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStockMovement.ForeColor = Color.White;
            btnStockMovement.Location = new Point(40, 290);
            btnStockMovement.Name = "btnStockMovement";
            btnStockMovement.Size = new Size(250, 70);
            btnStockMovement.TabIndex = 4;
            btnStockMovement.Text = "Stock In / Out";
            btnStockMovement.UseVisualStyleBackColor = false;
            btnStockMovement.Click += btnStockMovement_Click;
            //
            // btnRestock
            //
            btnRestock.BackColor = Color.FromArgb(111, 66, 193);
            btnRestock.Cursor = Cursors.Hand;
            btnRestock.FlatAppearance.BorderSize = 0;
            btnRestock.FlatStyle = FlatStyle.Flat;
            btnRestock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRestock.ForeColor = Color.White;
            btnRestock.Location = new Point(310, 290);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(250, 70);
            btnRestock.TabIndex = 5;
            btnRestock.Text = "Restock List";
            btnRestock.UseVisualStyleBackColor = false;
            btnRestock.Click += btnRestock_Click;
            //
            // btnHistory
            //
            btnHistory.BackColor = Color.FromArgb(23, 162, 184);
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(40, 380);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(250, 70);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "Stock History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            //
            // btnExit
            //
            btnExit.BackColor = Color.FromArgb(108, 117, 125);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(440, 475);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 540);
            Controls.Add(btnExit);
            Controls.Add(btnHistory);
            Controls.Add(btnRestock);
            Controls.Add(btnStockMovement);
            Controls.Add(btnCategories);
            Controls.Add(btnProducts);
            Controls.Add(lblLowStock);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblLowStock;
        private Button btnProducts;
        private Button btnCategories;
        private Button btnStockMovement;
        private Button btnRestock;
        private Button btnHistory;
        private Button btnExit;
    }
}
