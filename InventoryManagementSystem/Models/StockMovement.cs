using InventoryManagementSystem.Validation;

namespace InventoryManagementSystem.Models;

// A change in stock for one product (stock in or stock out)
public abstract class StockMovement : BaseEntity, IValidatable
{
    private int quantity;

    public int ProductId { get; set; }
    public string Note { get; set; } = "";
    public DateTime MovementDate { get; set; } = DateTime.Now;

    // Filled from the products table when movements are loaded
    public string ProductName { get; set; } = "";

    // Always a positive number, the type decides if it adds or removes
    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0)
            {
                throw new ValidationException("Quantity must be more than 0.");
            }
            quantity = value;
        }
    }

    // "IN" or "OUT", saved in the movement_type column
    public abstract string MovementType { get; }

    // How much the product quantity changes (+ for in, - for out)
    public abstract int GetQuantityChange();

    public void Validate()
    {
        if (ProductId <= 0)
        {
            throw new ValidationException("Please choose a product.");
        }
        if (Quantity <= 0)
        {
            throw new ValidationException("Quantity must be more than 0.");
        }
        if (Note != null && Note.Length > 200)
        {
            throw new ValidationException("Note must be 200 characters or less.");
        }
    }

    public override string GetDisplayText()
    {
        return MovementDate.ToString("dd/MM/yyyy HH:mm") + " " + MovementType + " " + Quantity;
    }

    public override string ToString()
    {
        return GetDisplayText();
    }
}
