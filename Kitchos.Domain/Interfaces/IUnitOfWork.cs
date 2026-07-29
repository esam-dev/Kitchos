using Kitchos.Domain.Entities;

namespace Kitchos.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IRepository<Recipe> Recipes { get; }
    IRepository<Category> Categories { get; }
    IRepository<Ingredient> Ingredients { get; }
    IRepository<Tag> Tags { get; }
    IRepository<Review> Reviews { get; }
    IRepository<Favorite> Favorites { get; }
    IRepository<MealPlan> MealPlans { get; }
    IRepository<MealPlanDay> MealPlanDays { get; }
    IRepository<ShoppingList> ShoppingLists { get; }
    IRepository<ShoppingListItem> ShoppingListItems { get; }
    IRepository<UnitOfMeasure> UnitsOfMeasure { get; }
    Task<int> SaveChangesAsync();
}
