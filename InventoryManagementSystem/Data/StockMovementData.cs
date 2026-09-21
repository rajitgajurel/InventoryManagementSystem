using InventoryManagementSystem.Models;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Data;

// Saves stock movements in the stock_movements table
public class StockMovementData
{
    // Uses the connection and transaction from InventoryService so it saves together with the quantity
    public void Add(StockMovement movement, MySqlConnection conn, MySqlTransaction transaction)
    {
        string sql = "INSERT INTO stock_movements (product_id, movement_type, quantity, note, movement_date) " +
                     "VALUES (@productId, @type, @quantity, @note, @date)";

        using (MySqlCommand cmd = new MySqlCommand(sql, conn, transaction))
        {
            cmd.Parameters.AddWithValue("@productId", movement.ProductId);
            cmd.Parameters.AddWithValue("@type", movement.MovementType);
            cmd.Parameters.AddWithValue("@quantity", movement.Quantity);
            cmd.Parameters.AddWithValue("@note", movement.Note == null ? "" : movement.Note.Trim());
            cmd.Parameters.AddWithValue("@date", movement.MovementDate);
            cmd.ExecuteNonQuery();

            movement.Id = (int)cmd.LastInsertedId;
        }
    }
}
