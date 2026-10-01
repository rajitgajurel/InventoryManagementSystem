using InventoryManagementSystem.Data;
using InventoryManagementSystem.Forms;

namespace InventoryManagementSystem;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Sets up the Windows Forms styles and default font
        ApplicationConfiguration.Initialize();

        // Check the database before opening the app
        string error;
        if (!DatabaseHelper.TestConnection(out error))
        {
            MessageBox.Show(error, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.Run(new MainForm());
    }
}
