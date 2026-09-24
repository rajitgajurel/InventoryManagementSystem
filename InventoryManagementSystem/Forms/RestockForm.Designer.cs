namespace InventoryManagementSystem.Forms
{
    partial class RestockForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblInfo = new Label();
            dgvRestock = new DataGridView();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colMinLevel = new DataGridViewTextBoxColumn();
            colOrder = new DataGridViewTextBoxColumn();
            lblCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).BeginInit();
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
            lblTitle.Size = new Size(158, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Restock List";
            //
            // lblInfo
            //
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.ForeColor = Color.DimGray;
            lblInfo.Location = new Point(20, 75);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(640, 23);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Products at or below their minimum stock level. Out of stock items are shown in red.";
            //
            // dgvRestock
            //
            dgvRestock.AllowUserToAddRows = false;
            dgvRestock.AllowUserToDeleteRows = false;
            dgvRestock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvRestock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRestock.BackgroundColor = Color.White;
            dgvRestock.BorderStyle = BorderStyle.FixedSingle;
            dgvRestock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRestock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvRestock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRestock.ColumnHeadersHeight = 36;
            dgvRestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRestock.Columns.AddRange(new DataGridViewColumn[] { colCode, colName, colCategory, colQuantity, colMinLevel, colOrder });
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvRestock.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRestock.EnableHeadersVisualStyles = false;
            dgvRestock.GridColor = Color.Gainsboro;
            dgvRestock.Location = new Point(20, 110);
            dgvRestock.MultiSelect = false;
            dgvRestock.Name = "dgvRestock";
            dgvRestock.ReadOnly = true;
            dgvRestock.RowHeadersVisible = false;
            dgvRestock.RowHeadersWidth = 51;
            dgvRestock.RowTemplate.Height = 32;
            dgvRestock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRestock.Size = new Size(820, 330);
            dgvRestock.TabIndex = 2;
            dgvRestock.CellFormatting += dgvRestock_CellFormatting;
            //
            // colCode
            //
            colCode.FillWeight = 14F;
            colCode.HeaderText = "Code";
            colCode.MinimumWidth = 6;
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            //
            // colName
            //
            colName.FillWeight = 28F;
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            //
            // colCategory
            //
            colCategory.FillWeight = 18F;
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            //
            // colQuantity
            //
            colQuantity.FillWeight = 10F;
            colQuantity.HeaderText = "Qty";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            //
            // colMinLevel
            //
            colMinLevel.FillWeight = 12F;
            colMinLevel.HeaderText = "Min Level";
            colMinLevel.MinimumWidth = 6;
            colMinLevel.Name = "colMinLevel";
            colMinLevel.ReadOnly = true;
            //
            // colOrder
            //
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colOrder.DefaultCellStyle = dataGridViewCellStyle4;
            colOrder.FillWeight = 14F;
            colOrder.HeaderText = "Order At Least";
            colOrder.MinimumWidth = 6;
            colOrder.Name = "colOrder";
            colOrder.ReadOnly = true;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(20, 450);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(146, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "Products to restock: 0";
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 123, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(590, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 4;
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
            btnClose.Location = new Point(720, 480);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // RestockForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(860, 535);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lblCount);
            Controls.Add(dgvRestock);
            Controls.Add(lblInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RestockForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Restock List";
            Load += RestockForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRestock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblInfo;
        private DataGridView dgvRestock;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colMinLevel;
        private DataGridViewTextBoxColumn colOrder;
        private Label lblCount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
