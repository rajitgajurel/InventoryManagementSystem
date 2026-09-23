namespace InventoryManagementSystem.Forms
{
    partial class ProductForm
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
            grpDetails = new GroupBox();
            lblCode = new Label();
            txtCode = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblMinLevel = new Label();
            txtMinLevel = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            lblCount = new Label();
            pnlHeader.SuspendLayout();
            grpDetails.SuspendLayout();
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
            lblTitle.Size = new Size(223, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Products";
            //
            // grpDetails
            //
            grpDetails.BackColor = Color.White;
            grpDetails.Controls.Add(lblCode);
            grpDetails.Controls.Add(txtCode);
            grpDetails.Controls.Add(lblName);
            grpDetails.Controls.Add(txtName);
            grpDetails.Controls.Add(lblQuantity);
            grpDetails.Controls.Add(txtQuantity);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(cboCategory);
            grpDetails.Controls.Add(lblPrice);
            grpDetails.Controls.Add(txtPrice);
            grpDetails.Controls.Add(lblMinLevel);
            grpDetails.Controls.Add(txtMinLevel);
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.Location = new Point(20, 75);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(880, 160);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Product Details";
            //
            // lblCode
            //
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 10F);
            lblCode.Location = new Point(20, 35);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(51, 23);
            lblCode.TabIndex = 0;
            lblCode.Text = "Code:";
            //
            // txtCode
            //
            txtCode.Font = new Font("Segoe UI", 10F);
            txtCode.Location = new Point(150, 32);
            txtCode.MaxLength = 20;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 30);
            txtCode.TabIndex = 1;
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(20, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            //
            // txtName
            //
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(150, 72);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 30);
            txtName.TabIndex = 3;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(20, 115);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(76, 23);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            //
            // txtQuantity
            //
            txtQuantity.Font = new Font("Segoe UI", 10F);
            txtQuantity.Location = new Point(150, 112);
            txtQuantity.MaxLength = 9;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(120, 30);
            txtQuantity.TabIndex = 5;
            //
            // lblCategory
            //
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F);
            lblCategory.Location = new Point(420, 35);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 23);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            //
            // cboCategory
            //
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 10F);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(570, 32);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(280, 31);
            cboCategory.TabIndex = 7;
            //
            // lblPrice
            //
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(420, 75);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(118, 23);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Unit Price ($):";
            //
            // txtPrice
            //
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(570, 72);
            txtPrice.MaxLength = 12;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(120, 30);
            txtPrice.TabIndex = 9;
            //
            // lblMinLevel
            //
            lblMinLevel.AutoSize = true;
            lblMinLevel.Font = new Font("Segoe UI", 10F);
            lblMinLevel.Location = new Point(420, 115);
            lblMinLevel.Name = "lblMinLevel";
            lblMinLevel.Size = new Size(137, 23);
            lblMinLevel.TabIndex = 10;
            lblMinLevel.Text = "Min Stock Level:";
            //
            // txtMinLevel
            //
            txtMinLevel.Font = new Font("Segoe UI", 10F);
            txtMinLevel.Location = new Point(570, 112);
            txtMinLevel.MaxLength = 9;
            txtMinLevel.Name = "txtMinLevel";
            txtMinLevel.Size = new Size(120, 30);
            txtMinLevel.TabIndex = 11;
            //
            // btnAdd
            //
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            //
            // btnUpdate
            //
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(150, 250);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(280, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            //
            // btnClear
            //
            btnClear.BackColor = Color.FromArgb(108, 117, 125);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(410, 250);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 38);
            btnClear.TabIndex = 5;
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
            dgvProducts.TabIndex = 6;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(20, 575);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(112, 20);
            lblCount.TabIndex = 7;
            lblCount.Text = "Total products: 0";
            //
            // ProductForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(920, 610);
            Controls.Add(lblCount);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpDetails);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Products";
            Load += ProductForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox grpDetails;
        private Label lblCode;
        private TextBox txtCode;
        private Label lblName;
        private TextBox txtName;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblMinLevel;
        private TextBox txtMinLevel;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private Label lblCount;
    }
}
