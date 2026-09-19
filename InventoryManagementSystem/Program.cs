using InventoryManagementSystem.Data;
using InventoryManagementSystem.Forms;

namespace InventoryManagementSystem;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
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