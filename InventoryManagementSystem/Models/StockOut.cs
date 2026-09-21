namespace InventoryManagementSystem.Models;

// Stock leaving the shop, e.g. a sale or damaged items
public class StockOut : StockMovement
{
    public override string MovementType
    {
        get { return "OUT"; }
    }

    // Stock out takes away from the product quantity
    public override int GetQuantityChange()
    {
        return -Quantity;
    }
}
