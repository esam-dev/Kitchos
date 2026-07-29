using Kitchos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kitchos.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<Ingredient> Ingredients => Set<Ingredient>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<RecipeTag> RecipeTags => Set<RecipeTag>();
    public DbSet<MealPlan> MealPlans => Set<MealPlan>();
    public DbSet<MealPlanDay> MealPlanDays => Set<MealPlanDay>();
    public DbSet<ShoppingList> ShoppingLists => Set<ShoppingList>();
    public DbSet<ShoppingListItem> ShoppingListItems => Set<ShoppingListItem>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<Favorite> Favorites => Set<Favorite>();
    public DbSet<UnitOfMeasure> UnitsOfMeasure => Set<UnitOfMeasure>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RecipeTag>()
            .HasKey(rt => new { rt.RecipeId, rt.TagId });

        modelBuilder.Entity<RecipeTag>()
            .HasOne(rt => rt.Recipe)
            .WithMany(r => r.RecipeTags)
            .HasForeignKey(rt => rt.RecipeId);

        modelBuilder.Entity<RecipeTag>()
            .HasOne(rt => rt.Tag)
            .WithMany(t => t.RecipeTags)
            .HasForeignKey(rt => rt.TagId);

        modelBuilder.Entity<Recipe>()
            .HasOne(r => r.Category)
            .WithMany(c => c.Recipes)
            .HasForeignKey(r => r.CategoryId);

        modelBuilder.Entity<Ingredient>()
            .HasOne(i => i.Recipe)
            .WithMany(r => r.Ingredients)
            .HasForeignKey(i => i.RecipeId);

        modelBuilder.Entity<Ingredient>()
            .HasOne(i => i.UnitOfMeasure)
            .WithMany(u => u.Ingredients)
            .HasForeignKey(i => i.UnitOfMeasureId);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Recipe)
            .WithMany(r => r.Reviews)
            .HasForeignKey(r => r.RecipeId);

        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.Recipe)
            .WithMany(r => r.Favorites)
            .HasForeignKey(f => f.RecipeId);

        modelBuilder.Entity<MealPlanDay>()
            .HasOne(m => m.MealPlan)
            .WithMany(m => m.MealPlanDays)
            .HasForeignKey(m => m.MealPlanId);

        modelBuilder.Entity<MealPlanDay>()
            .HasOne(m => m.Recipe)
            .WithMany()
            .HasForeignKey(m => m.RecipeId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<ShoppingListItem>()
            .HasOne(s => s.ShoppingList)
            .WithMany(s => s.Items)
            .HasForeignKey(s => s.ShoppingListId);

        modelBuilder.Entity<ShoppingListItem>()
            .HasOne(s => s.UnitOfMeasure)
            .WithMany(u => u.ShoppingListItems)
            .HasForeignKey(s => s.UnitOfMeasureId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
