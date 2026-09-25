namespace InventoryManagementSystem.Models;

// Totals for one category in the stock summary report
public class CategorySummary
{
    public string CategoryName { get; set; } = "";
    public int ProductCount { get; set; }
    public int TotalUnits { get; set; }
    public decimal TotalValue { get; set; }
    public int LowStockCount { get; set; }
}
