namespace InventoryManagementSystem.Models;

// Base class for anything stored in the database with an id
public abstract class BaseEntity
{
    public int Id { get; set; }

    // Each class decides how it is shown in lists
    public abstract string GetDisplayText();
}
