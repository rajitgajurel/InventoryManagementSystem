namespace InventoryManagementSystem.Forms
{
    partial class StockMovementForm
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
            grpMovement = new GroupBox();
            lblProduct = new Label();
            cboProduct = new ComboBox();
            lblCurrentStock = new Label();
            lblType = new Label();
            rdoStockIn = new RadioButton();
            rdoStockOut = new RadioButton();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblNote = new Label();
            txtNote = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            lblCount = new Label();
            pnlHeader.SuspendLayout();
            grpMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(33, 64, 95);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(920, 60);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock In / Stock Out";
            //
            // grpMovement
            //
            grpMovement.BackColor = Color.White;
            grpMovement.Controls.Add(lblProduct);
            grpMovement.Controls.Add(cboProduct);
            grpMovement.Controls.Add(lblCurrentStock);
            grpMovement.Controls.Add(lblType);
            grpMovement.Controls.Add(rdoStockIn);
            grpMovement.Controls.Add(rdoStockOut);
            grpMovement.Controls.Add(lblQuantity);
            grpMovement.Controls.Add(txtQuantity);
            grpMovement.Controls.Add(lblNote);
            grpMovement.Controls.Add(txtNote);
            grpMovement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMovement.Location = new Point(20, 75);
            grpMovement.Name = "grpMovement";
            grpMovement.Size = new Size(880, 160);
            grpMovement.TabIndex = 1;
            grpMovement.TabStop = false;
            grpMovement.Text = "Stock Movement";
            //
            // lblProduct
            //
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10F);
            lblProduct.Location = new Point(20, 35);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(72, 23);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product:";
            //
            // cboProduct
            //
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.Font = new Font("Segoe UI", 10F);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(150, 32);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(320, 31);
            cboProduct.TabIndex = 1;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            //
            // lblCurrentStock
            //
            lblCurrentStock.AutoSize = true;
            lblCurrentStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrentStock.ForeColor = Color.FromArgb(33, 64, 95);
            lblCurrentStock.Location = new Point(490, 35);
            lblCurrentStock.Name = "lblCurrentStock";
            lblCurrentStock.Size = new Size(134, 23);
            lblCurrentStock.TabIndex = 2;
            lblCurrentStock.Text = "Current stock: -";
            //
            // lblType
            //
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.Location = new Point(20, 75);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 23);
            lblType.TabIndex = 3;
            lblType.Text = "Type:";
            //
            // rdoStockIn
            //
            rdoStockIn.AutoSize = true;
            rdoStockIn.Checked = true;
            rdoStockIn.Font = new Font("Segoe UI", 10F);
            rdoStockIn.Location = new Point(150, 73);
            rdoStockIn.Name = "rdoStockIn";
            rdoStockIn.Size = new Size(88, 27);
            rdoStockIn.TabIndex = 4;
            rdoStockIn.TabStop = true;
            rdoStockIn.Text = "Stock In";
            rdoStockIn.UseVisualStyleBackColor = true;
            //
            // rdoStockOut
            //
            rdoStockOut.AutoSize = true;
            rdoStockOut.Font = new Font("Segoe UI", 10F);
            rdoStockOut.Location = new Point(270, 73);
            rdoStockOut.Name = "rdoStockOut";
            rdoStockOut.Size = new Size(101, 27);
            rdoStockOut.TabIndex = 5;
            rdoStockOut.Text = "Stock Out";
            rdoStockOut.UseVisualStyleBackColor = true;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(20, 115);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(76, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            //
            // txtQuantity
            //
            txtQuantity.Font = new Font("Segoe UI", 10F);
            txtQuantity.Location = new Point(150, 112);
            txtQuantity.MaxLength = 9;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 30);
            txtQuantity.TabIndex = 7;
            //
            // lblNote
            //
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10F);
            lblNote.Location = new Point(420, 115);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(49, 23);
            lblNote.TabIndex = 8;
            lblNote.Text = "Note:";
            //
            // txtNote
            //
            txtNote.Font = new Font("Segoe UI", 10F);
            txtNote.Location = new Point(490, 112);
            txtNote.MaxLength = 200;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(360, 30);
            txtNote.TabIndex = 9;
            //
            // btnSave
            //
            btnSave.BackColor = Color.FromArgb(40, 167, 69);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            //
            // btnClear
            //
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(150, 250);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            //
            // dgvProducts
            //
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.FixedSingle;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 36;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.Gainsboro;
            dgvProducts.Location = new Point(20, 305);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 32;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(880, 260);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellClick += dgvProducts_CellClick;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(20, 575);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(112, 20);
            lblCount.TabIndex = 5;
            lblCount.Text = "Total products: 0";
            //
            // StockMovementForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(920, 610);
            Controls.Add(lblCount);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(grpMovement);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StockMovementForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock In / Out";
            Load += StockMovementForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpMovement.ResumeLayout(false);
            grpMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox grpMovement;
        private Label lblProduct;
        private ComboBox cboProduct;
        private Label lblCurrentStock;
        private Label lblType;
        private RadioButton rdoStockIn;
        private RadioButton rdoStockOut;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dgvProducts;
        private Label lblCount;
    }
}
