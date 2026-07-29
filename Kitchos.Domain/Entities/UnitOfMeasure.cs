namespace Kitchos.Domain.Entities;

public class UnitOfMeasure
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Abbreviation { get; set; } = string.Empty;
    public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public ICollection<ShoppingListItem> ShoppingListItems { get; set; } = new List<ShoppingListItem>();
}
