using Kitchos.Domain.Entities;
using Kitchos.Domain.Interfaces;
using Kitchos.Infrastructure.Data;

namespace Kitchos.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IRepository<Recipe>? _recipes;
    private IRepository<Category>? _categories;
    private IRepository<Ingredient>? _ingredients;
    private IRepository<Tag>? _tags;
    private IRepository<Review>? _reviews;
    private IRepository<Favorite>? _favorites;
    private IRepository<MealPlan>? _mealPlans;
    private IRepository<MealPlanDay>? _mealPlanDays;
    private IRepository<ShoppingList>? _shoppingLists;
    private IRepository<ShoppingListItem>? _shoppingListItems;
    private IRepository<UnitOfMeasure>? _unitsOfMeasure;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IRepository<Recipe> Recipes => _recipes ??= new Repository<Recipe>(_context);
    public IRepository<Category> Categories => _categories ??= new Repository<Category>(_context);
    public IRepository<Ingredient> Ingredients => _ingredients ??= new Repository<Ingredient>(_context);
    public IRepository<Tag> Tags => _tags ??= new Repository<Tag>(_context);
    public IRepository<Review> Reviews => _reviews ??= new Repository<Review>(_context);
    public IRepository<Favorite> Favorites => _favorites ??= new Repository<Favorite>(_context);
    public IRepository<MealPlan> MealPlans => _mealPlans ??= new Repository<MealPlan>(_context);
    public IRepository<MealPlanDay> MealPlanDays => _mealPlanDays ??= new Repository<MealPlanDay>(_context);
    public IRepository<ShoppingList> ShoppingLists => _shoppingLists ??= new Repository<ShoppingList>(_context);
    public IRepository<ShoppingListItem> ShoppingListItems => _shoppingListItems ??= new Repository<ShoppingListItem>(_context);
    public IRepository<UnitOfMeasure> UnitsOfMeasure => _unitsOfMeasure ??= new Repository<UnitOfMeasure>(_context);

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
