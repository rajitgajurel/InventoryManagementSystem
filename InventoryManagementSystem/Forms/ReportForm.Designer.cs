namespace InventoryManagementSystem.Forms
{
    partial class ReportForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblCreated = new Label();
            lblProducts = new Label();
            lblUnits = new Label();
            lblValue = new Label();
            lblLowStock = new Label();
            lblOutOfStock = new Label();
            lblByCategory = new Label();
            dgvCategories = new DataGridView();
            colCategory = new DataGridViewTextBoxColumn();
            colProducts = new DataGridViewTextBoxColumn();
            colUnits = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            colLowStock = new DataGridViewTextBoxColumn();
            lblCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(33, 64, 95);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(860, 60);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Summary Report";
            //
            // lblCreated
            //
            lblCreated.AutoSize = true;
            lblCreated.Font = new Font("Segoe UI", 10F);
            lblCreated.ForeColor = Color.DimGray;
            lblCreated.Location = new Point(20, 72);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(130, 23);
            lblCreated.TabIndex = 1;
            lblCreated.Text = "Report made on";
            //
            // lblProducts
            //
            lblProducts.BackColor = Color.White;
            lblProducts.BorderStyle = BorderStyle.FixedSingle;
            lblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProducts.ForeColor = Color.FromArgb(33, 64, 95);
            lblProducts.Location = new Point(20, 105);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(155, 80);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "Products\n0";
            lblProducts.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblUnits
            //
            lblUnits.BackColor = Color.White;
            lblUnits.BorderStyle = BorderStyle.FixedSingle;
            lblUnits.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUnits.ForeColor = Color.FromArgb(33, 64, 95);
            lblUnits.Location = new Point(186, 105);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(155, 80);
            lblUnits.TabIndex = 3;
            lblUnits.Text = "Units in Stock\n0";
            lblUnits.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblValue
            //
            lblValue.BackColor = Color.White;
            lblValue.BorderStyle = BorderStyle.FixedSingle;
            lblValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(33, 64, 95);
            lblValue.Location = new Point(352, 105);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(155, 80);
            lblValue.TabIndex = 4;
            lblValue.Text = "Stock Value\n$0.00";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblLowStock
            //
            lblLowStock.BackColor = Color.White;
            lblLowStock.BorderStyle = BorderStyle.FixedSingle;
            lblLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.FromArgb(33, 64, 95);
            lblLowStock.Location = new Point(518, 105);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(155, 80);
            lblLowStock.TabIndex = 5;
            lblLowStock.Text = "Low Stock\n0";
            lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblOutOfStock
            //
            lblOutOfStock.BackColor = Color.White;
            lblOutOfStock.BorderStyle = BorderStyle.FixedSingle;
            lblOutOfStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOutOfStock.ForeColor = Color.FromArgb(33, 64, 95);
            lblOutOfStock.Location = new Point(684, 105);
            lblOutOfStock.Name = "lblOutOfStock";
            lblOutOfStock.Size = new Size(155, 80);
            lblOutOfStock.TabIndex = 6;
            lblOutOfStock.Text = "Out of Stock\n0";
            lblOutOfStock.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblByCategory
            //
            lblByCategory.AutoSize = true;
            lblByCategory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblByCategory.ForeColor = Color.FromArgb(33, 64, 95);
            lblByCategory.Location = new Point(20, 200);
            lblByCategory.Name = "lblByCategory";
            lblByCategory.Size = new Size(172, 25);
            lblByCategory.TabIndex = 7;
            lblByCategory.Text = "Totals by Category";
            //
            // dgvCategories
            //
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.FixedSingle;
            dgvCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.ColumnHeadersHeight = 36;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { colCategory, colProducts, colUnits, colValue, colLowStock });
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.GridColor = Color.Gainsboro;
            dgvCategories.Location = new Point(20, 232);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 32;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(820, 230);
            dgvCategories.TabIndex = 8;
            //
            // colCategory
            //
            colCategory.FillWeight = 30F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            //
            // colProducts
            //
            colProducts.FillWeight = 15F;
            colProducts.HeaderText = "Products";
            colProducts.MinimumWidth = 6;
            colProducts.Name = "colProducts";
            colProducts.ReadOnly = true;
            //
            // colUnits
            //
            colUnits.FillWeight = 15F;
            colUnits.HeaderText = "Units";
            colUnits.MinimumWidth = 6;
            colUnits.Name = "colUnits";
            colUnits.ReadOnly = true;
            //
            // colValue
            //
            colValue.FillWeight = 22F;
            colValue.HeaderText = "Stock Value";
            colValue.MinimumWidth = 6;
            colValue.Name = "colValue";
            colValue.ReadOnly = true;
            //
            // colLowStock
            //
            colLowStock.FillWeight = 18F;
            colLowStock.HeaderText = "Low Stock";
            colLowStock.MinimumWidth = 6;
            colLowStock.Name = "colLowStock";
            colLowStock.ReadOnly = true;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(20, 472);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(190, 20);
            lblCount.TabIndex = 9;
            lblCount.Text = "Categories with products: 0";
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 123, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(590, 500);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnClose
            //
            btnClose.BackColor = Color.FromArgb(108, 117, 125);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(720, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // ReportForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(860, 555);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lblCount);
            Controls.Add(dgvCategories);
            Controls.Add(lblByCategory);
            Controls.Add(lblOutOfStock);
            Controls.Add(lblLowStock);
            Controls.Add(lblValue);
            Controls.Add(lblUnits);
            Controls.Add(lblProducts);
            Controls.Add(lblCreated);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock Summary Report";
            Load += ReportForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblCreated;
        private Label lblProducts;
        private Label lblUnits;
        private Label lblValue;
        private Label lblLowStock;
        private Label lblOutOfStock;
        private Label lblByCategory;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colProducts;
        private DataGridViewTextBoxColumn colUnits;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colLowStock;
        private Label lblCount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
