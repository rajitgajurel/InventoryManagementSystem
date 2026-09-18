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
}
