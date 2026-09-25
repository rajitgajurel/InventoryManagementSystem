namespace InventoryManagementSystem.Models;

// The whole stock summary report, made by ReportService
public class StockSummary
{
    public int ProductCount { get; set; }
    public int TotalUnits { get; set; }
    public decimal TotalValue { get; set; }
    public int LowStockCount { get; set; }
    public int OutOfStockCount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // One row per category
    public List<CategorySummary> Categories { get; set; } = new List<CategorySummary>();
}
