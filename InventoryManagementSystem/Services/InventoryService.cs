using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Validation;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Services;

// Handles stock in and stock out for products
public class InventoryService
{
    private ProductData productData = new ProductData();
    private StockMovementData movementData = new StockMovementData();

    // Records a delivery and adds the quantity to the product
    public StockIn AddStock(int productId, int quantity, string note)
    {
        StockIn movement = new StockIn();
        movement.ProductId = productId;
        movement.Quantity = quantity;
        movement.Note = note;
        movement.Validate();

        SaveMovement(movement);
        return movement;
    }

    // Records a sale or removal and takes the quantity away from the product
    public StockOut RemoveStock(int productId, int quantity, string note)
    {
        StockOut movement = new StockOut();
        movement.ProductId = productId;
        movement.Quantity = quantity;
        movement.Note = note;
        movement.Validate();

        SaveMovement(movement);
        return movement;
    }

    // Updates the quantity and saves the movement together, so both work or neither does
    private void SaveMovement(StockMovement movement)
    {
        using (MySqlConnection conn = DatabaseHelper.GetConnection())
        {
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            try
            {
                // Stock out cannot take more than what is in stock
                if (movement.GetQuantityChange() < 0)
                {
                    int currentQuantity = productData.GetQuantity(movement.ProductId, conn, transaction);
                    if (movement.Quantity > currentQuantity)
                    {
                        throw new ValidationException("Not enough stock. Only " + currentQuantity + " left.");
                    }
                }

                // StockIn gives +quantity, StockOut gives -quantity
                productData.ChangeQuantity(movement.ProductId, movement.GetQuantityChange(), conn, transaction);
                movementData.Add(movement, conn, transaction);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
