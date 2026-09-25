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

    // All movements, newest first
    public List<StockMovement> GetAll()
    {
        List<StockMovement> movements = new List<StockMovement>();

        string sql = "SELECT m.movement_id, m.product_id, p.product_name, m.movement_type, m.quantity, m.note, m.movement_date " +
                     "FROM stock_movements m INNER JOIN products p ON m.product_id = p.product_id " +
                     "ORDER BY m.movement_date DESC, m.movement_id DESC";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    movements.Add(ReadMovement(reader));
                }
            }
        }
        return movements;
    }

    // Movements for one product only, newest first
    public List<StockMovement> GetByProduct(int productId)
    {
        List<StockMovement> movements = new List<StockMovement>();

        string sql = "SELECT m.movement_id, m.product_id, p.product_name, m.movement_type, m.quantity, m.note, m.movement_date " +
                     "FROM stock_movements m INNER JOIN products p ON m.product_id = p.product_id " +
                     "WHERE m.product_id = @productId " +
                     "ORDER BY m.movement_date DESC, m.movement_id DESC";

        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@productId", productId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movements.Add(ReadMovement(reader));
                    }
                }
            }
        }
        return movements;
    }

    // Makes a StockIn or StockOut object depending on the movement_type column
    private StockMovement ReadMovement(MySqlDataReader reader)
    {
        StockMovement movement;
        if (reader.GetString("movement_type") == "IN")
        {
            movement = new StockIn();
        }
        else
        {
            movement = new StockOut();
        }

        movement.Id = reader.GetInt32("movement_id");
        movement.ProductId = reader.GetInt32("product_id");
        movement.ProductName = reader.GetString("product_name");
        movement.Quantity = reader.GetInt32("quantity");
        movement.MovementDate = reader.GetDateTime("movement_date");

        // Note can be NULL in the database
        if (reader.IsDBNull(reader.GetOrdinal("note")))
        {
            movement.Note = "";
        }
        else
        {
            movement.Note = reader.GetString("note");
        }
        return movement;
    }
}
