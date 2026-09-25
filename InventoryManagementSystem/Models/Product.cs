using InventoryManagementSystem.Validation;

namespace InventoryManagementSystem.Models;

// A product sold in the shop
public class Product : BaseEntity, IValidatable
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
                throw new ValidationException("Unit price cannot be negative.");
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
                throw new ValidationException("Quantity cannot be negative.");
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
                throw new ValidationException("Minimum stock level cannot be negative.");
            }
            minStockLevel = value;
        }
    }

    // Checks everything before the product is saved
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Code))
        {
            throw new ValidationException("Product code is required.");
        }
        if (Code.Trim().Length > 20)
        {
            throw new ValidationException("Product code must be 20 characters or less.");
        }
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ValidationException("Product name is required.");
        }
        if (Name.Trim().Length > 100)
        {
            throw new ValidationException("Product name must be 100 characters or less.");
        }
        if (CategoryId <= 0)
        {
            throw new ValidationException("Please choose a category.");
        }
        if (UnitPrice < 0)
        {
            throw new ValidationException("Unit price cannot be negative.");
        }
        if (Quantity < 0)
        {
            throw new ValidationException("Quantity cannot be negative.");
        }
        if (MinStockLevel < 0)
        {
            throw new ValidationException("Minimum stock level cannot be negative.");
        }
    }

    // Low stock when quantity is at or below the minimum level
    public bool IsLowStock()
    {
        return Quantity <= MinStockLevel;
    }

    // How many to order so the quantity goes back above the minimum level
    public int GetRestockAmount()
    {
        if (!IsLowStock())
        {
            return 0;
        }
        return MinStockLevel - Quantity + 1;
    }

    // Value of the stock on hand (price x quantity)
    public decimal GetStockValue()
    {
        return UnitPrice * Quantity;
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
