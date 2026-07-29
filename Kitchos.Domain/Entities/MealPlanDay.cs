namespace Kitchos.Domain.Entities;

public class MealPlanDay
{
    public Guid Id { get; set; }
    public Guid MealPlanId { get; set; }
    public MealPlan MealPlan { get; set; } = null!;
    public DateTime Date { get; set; }
    public string MealType { get; set; } = string.Empty;
    public Guid? RecipeId { get; set; }
    public Recipe? Recipe { get; set; }
}
