namespace Kitchos.Domain.Entities;

public class Favorite
{
    public Guid Id { get; set; }
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; } = null!;
    public string UserId { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
