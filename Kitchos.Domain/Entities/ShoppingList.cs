namespace Kitchos.Domain.Entities;

public class ShoppingList
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsCompleted { get; set; }
    public ICollection<ShoppingListItem> Items { get; set; } = new List<ShoppingListItem>();
}
