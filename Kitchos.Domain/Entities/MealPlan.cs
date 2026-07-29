namespace Kitchos.Domain.Entities;

public class MealPlan
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string UserId { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public ICollection<MealPlanDay> MealPlanDays { get; set; } = new List<MealPlanDay>();
}
