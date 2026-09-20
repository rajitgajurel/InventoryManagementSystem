namespace InventoryManagementSystem.Validation;

// Thrown when the user types something that is not allowed
public class ValidationException : Exception
{
    public ValidationException(string message) : base(message)
    {
    }
}
