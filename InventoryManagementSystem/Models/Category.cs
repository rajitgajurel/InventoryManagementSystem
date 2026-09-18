using InventoryManagementSystem.Validation;

namespace InventoryManagementSystem.Models;

// A product category, e.g. Drinks or Snacks
public class Category : BaseEntity, IValidatable
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new Exception("Category name is required.");
        }
        if (Name.Trim().Length > 50)
        {
            throw new Exception("Category name must be 50 characters or less.");
        }
        if (Description != null && Description.Length > 200)
        {
            throw new Exception("Description must be 200 characters or less.");
        }
    }

    public override string GetDisplayText()
    {
        return Name;
    }

    // Used by combo boxes and list boxes
    public override string ToString()
    {
        return GetDisplayText();
    }
}
