using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services;

// Works out the numbers for the stock summary report
public class ReportService
{
    private ProductData productData = new ProductData();

    // Loads all products and adds up the totals
    public StockSummary GetStockSummary()
    {
        List<Product> products = productData.GetAll();
        StockSummary summary = new StockSummary();

        foreach (Product product in products)
        {
            summary.ProductCount++;
            summary.TotalUnits += product.Quantity;
            summary.TotalValue += product.GetStockValue();

            if (product.IsLowStock())
            {
                summary.LowStockCount++;
            }
            if (product.Quantity == 0)
            {
                summary.OutOfStockCount++;
            }

            // Add the product to its category row
            CategorySummary category = FindCategory(summary.Categories, product.CategoryName);
            if (category == null)
            {
                category = new CategorySummary();
                category.CategoryName = product.CategoryName;
                summary.Categories.Add(category);
            }

            category.ProductCount++;
            category.TotalUnits += product.Quantity;
            category.TotalValue += product.GetStockValue();
            if (product.IsLowStock())
            {
                category.LowStockCount++;
            }
        }

        return summary;
    }

    // Returns the category row with this name, or null if it is not in the list yet
    private CategorySummary FindCategory(List<CategorySummary> categories, string name)
    {
        foreach (CategorySummary category in categories)
        {
            if (category.CategoryName == name)
            {
                return category;
            }
        }
        return null;
    }
}
