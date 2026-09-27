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
        catch (Exception ex)
        {
            errorMessage = GetFriendlyMessage(ex);
            return false;
        }
    }

    // Turns a database error into a message the shop user can understand
    public static string GetFriendlyMessage(Exception ex)
    {
        MySqlException mysqlError = ex as MySqlException;
        if (mysqlError == null)
        {
            return ex.Message;
        }

        // MySQL error numbers
        if (mysqlError.Number == 0 || mysqlError.Number == 1042)
        {
            return "Cannot connect to the database. Make sure MySQL is running in XAMPP, then try again.";
        }
        if (mysqlError.Number == 1045)
        {
            return "The database user name or password in App.config is wrong.";
        }
        if (mysqlError.Number == 1049)
        {
            return "The database inventory_db was not found. Run Database/inventory_db.sql first.";
        }
        if (mysqlError.Number == 1062)
        {
            return "This value already exists. Please enter a different one.";
        }
        if (mysqlError.Number == 1451)
        {
            return "This record is still used by other records, so it cannot be deleted.";
        }
        if (mysqlError.Number == 1406)
        {
            return "One of the values is too long.";
        }
        return "Something went wrong with the database. Please try again.\n\nDetails: " + mysqlError.Message;
    }
}
