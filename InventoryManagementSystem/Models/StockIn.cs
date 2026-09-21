namespace InventoryManagementSystem.Models;

// Stock coming into the shop, e.g. a delivery from a supplier
public class StockIn : StockMovement
{
    public override string MovementType
    {
        get { return "IN"; }
    }

    // Stock in adds to the product quantity
    public override int GetQuantityChange()
    {
        return Quantity;
    }
}
