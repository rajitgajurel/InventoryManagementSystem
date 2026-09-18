namespace InventoryManagementSystem.Validation;

// Classes that can check their own data before saving
public interface IValidatable
{
    // Throws an exception if the data is not valid
    void Validate();
}
