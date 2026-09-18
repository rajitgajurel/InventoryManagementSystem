namespace InventoryManagementSystem;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnCategories = new Button();
        SuspendLayout();
        //
        // btnCategories
        //
        btnCategories.Location = new Point(30, 30);
        btnCategories.Name = "btnCategories";
        btnCategories.Size = new Size(160, 40);
        btnCategories.TabIndex = 0;
        btnCategories.Text = "Categories";
        btnCategories.UseVisualStyleBackColor = true;
        btnCategories.Click += btnCategories_Click;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnCategories);
        Name = "Form1";
        Text = "Inventory Management System";
        ResumeLayout(false);
    }

    #endregion

    private Button btnCategories;
}
