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
                // long so two very big numbers can't wrap around when added
                int currentQuantity = productData.GetQuantity(movement.ProductId, conn, transaction);
                long newQuantity = (long)currentQuantity + movement.GetQuantityChange();

                // Stock out cannot take more than what is in stock
                if (newQuantity < 0)
                {
                    throw new ValidationException("Not enough stock. Only " + currentQuantity + " left.");
                }

                // Stock in cannot go over the biggest quantity a product can have
                if (movement.GetQuantityChange() > 0 && newQuantity > Product.MaxQuantity)
                {
                    throw new ValidationException("Too much stock. A product can have at most " + Product.MaxQuantity.ToString("N0") + " units.");
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
