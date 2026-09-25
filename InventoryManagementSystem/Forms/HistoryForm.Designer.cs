namespace InventoryManagementSystem.Forms
{
    partial class HistoryForm
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
            lblProduct = new Label();
            cboProduct = new ComboBox();
            dgvHistory = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colProduct = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colChange = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            lblCount = new Label();
            btnRefresh = new Button();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
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
            lblTitle.Size = new Size(220, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Movement History";
            //
            // lblProduct
            //
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProduct.Location = new Point(20, 78);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(72, 23);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product:";
            //
            // cboProduct
            //
            cboProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduct.Font = new Font("Segoe UI", 10F);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(100, 75);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(350, 31);
            cboProduct.TabIndex = 2;
            cboProduct.SelectedIndexChanged += cboProduct_SelectedIndexChanged;
            //
            // dgvHistory
            //
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 245, 250);
            dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.BorderStyle = BorderStyle.FixedSingle;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(33, 64, 95);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.ColumnHeadersHeight = 36;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colDate, colProduct, colType, colChange, colNote });
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(173, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.Gainsboro;
            dgvHistory.Location = new Point(20, 120);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 32;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(820, 330);
            dgvHistory.TabIndex = 3;
            dgvHistory.CellFormatting += dgvHistory_CellFormatting;
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
            colProduct.FillWeight = 26F;
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            //
            // colType
            //
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colType.DefaultCellStyle = dataGridViewCellStyle4;
            colType.FillWeight = 8F;
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
            colNote.FillWeight = 38F;
            colNote.HeaderText = "Note";
            colNote.MinimumWidth = 6;
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblCount.ForeColor = Color.DimGray;
            lblCount.Location = new Point(20, 460);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(95, 20);
            lblCount.TabIndex = 4;
            lblCount.Text = "Movements: 0";
            //
            // btnRefresh
            //
            btnRefresh.BackColor = Color.FromArgb(0, 123, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(590, 490);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.TabIndex = 5;
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
            btnClose.Location = new Point(720, 490);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 38);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            //
            // HistoryForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(860, 545);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lblCount);
            Controls.Add(dgvHistory);
            Controls.Add(cboProduct);
            Controls.Add(lblProduct);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stock Movement History";
            Load += HistoryForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblProduct;
        private ComboBox cboProduct;
        private DataGridView dgvHistory;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colChange;
        private DataGridViewTextBoxColumn colNote;
        private Label lblCount;
        private Button btnRefresh;
        private Button btnClose;
    }
}
