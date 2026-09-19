using InventoryManagementSystem.Forms;

namespace InventoryManagementSystem;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    // Opens the categories screen
    private void btnCategories_Click(object sender, EventArgs e)
    {
        CategoryForm form = new CategoryForm();
        form.ShowDialog();
    }

    // Opens the products screen
    private void btnProducts_Click(object sender, EventArgs e)
    {
        ProductForm form = new ProductForm();
        form.ShowDialog();
    }
}
