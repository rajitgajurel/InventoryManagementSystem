namespace InventoryManagementSystem.Models;

// A product sold in the shop
public class Product : BaseEntity
{
    // Private fields so bad numbers can't be set directly
    private decimal unitPrice;
    private int quantity;
    private int minStockLevel;

    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public int CategoryId { get; set; }

    // Filled from the categories table when products are loaded
    public string CategoryName { get; set; } = "";

    public decimal UnitPrice
    {
        get { return unitPrice; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Unit price cannot be negative.");
            }
            unitPrice = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
            quantity = value;
        }
    }

    public int MinStockLevel
    {
        get { return minStockLevel; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Minimum stock level cannot be negative.");
            }
            minStockLevel = value;
        }
    }

    // Low stock when quantity is at or below the minimum level
    public bool IsLowStock()
    {
        return Quantity <= MinStockLevel;
    }

    public override string GetDisplayText()
    {
        return Code + " - " + Name;
    }

    public override string ToString()
    {
        return GetDisplayText();
    }
}
