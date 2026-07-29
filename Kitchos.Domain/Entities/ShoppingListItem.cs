namespace Kitchos.Domain.Entities;

public class ShoppingListItem
{
    public Guid Id { get; set; }
    public Guid ShoppingListId { get; set; }
    public ShoppingList ShoppingList { get; set; } = null!;
    public string Name { get; set; } = string.Empty;
    public decimal Quantity { get; set; }
    public Guid? UnitOfMeasureId { get; set; }
    public UnitOfMeasure? UnitOfMeasure { get; set; }
    public bool IsChecked { get; set; }
}
