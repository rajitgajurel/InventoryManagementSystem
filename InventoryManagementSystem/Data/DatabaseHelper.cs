using System.Configuration;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Data;

// Gives the rest of the app a connection to the MySQL database
public static class DatabaseHelper
{
    public static MySqlConnection GetConnection()
    {
        ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["InventoryDb"];

        // App.config is not on GitHub, so it may be missing
        if (setting == null)
        {
            throw new Exception("Connection string 'InventoryDb' not found. Copy App.config.example to App.config.");
        }

        return new MySqlConnection(setting.ConnectionString);
    }

    // Returns true if the database can be opened, otherwise puts the reason in errorMessage
    public static bool TestConnection(out string errorMessage)
    {
        errorMessage = "";
        try
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
            }
            return true;
        }
        catch (MySqlException ex)
        {
            errorMessage = "Could not connect to MySQL. Make sure MySQL is running in XAMPP.\n\n" + ex.Message;
            return false;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
            return false;
        }
    }
}
