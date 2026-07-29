using Kitchos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kitchos.Infrastructure.Data;

public static class DbInitializer
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (await context.UnitsOfMeasure.AnyAsync()) return;

        var units = new List<UnitOfMeasure>
        {
            new() { Id = Guid.NewGuid(), Name = "Unidad", Abbreviation = "unid" },
            new() { Id = Guid.NewGuid(), Name = "Gramo", Abbreviation = "g" },
            new() { Id = Guid.NewGuid(), Name = "Kilogramo", Abbreviation = "kg" },
            new() { Id = Guid.NewGuid(), Name = "Mililitro", Abbreviation = "ml" },
            new() { Id = Guid.NewGuid(), Name = "Litro", Abbreviation = "l" },
            new() { Id = Guid.NewGuid(), Name = "Cucharadita", Abbreviation = "cdta" },
            new() { Id = Guid.NewGuid(), Name = "Cucharada", Abbreviation = "cda" },
            new() { Id = Guid.NewGuid(), Name = "Taza", Abbreviation = "tza" },
            new() { Id = Guid.NewGuid(), Name = "Pizca", Abbreviation = "pizca" },
        };

        var categories = new List<Category>
        {
            new() { Id = Guid.NewGuid(), Name = "Desayuno", Description = "Recetas para empezar el día" },
            new() { Id = Guid.NewGuid(), Name = "Almuerzo", Description = "Platos fuertes para medio día" },
            new() { Id = Guid.NewGuid(), Name = "Cena", Description = "Comidas ligeras para la noche" },
            new() { Id = Guid.NewGuid(), Name = "Postre", Description = "Dulces y tentempiés" },
            new() { Id = Guid.NewGuid(), Name = "Ensalada", Description = "Ensaladas y platos frescos" },
            new() { Id = Guid.NewGuid(), Name = "Sopa", Description = "Sopas y caldos" },
            new() { Id = Guid.NewGuid(), Name = "Bebida", Description = "Bebidas y smoothies" },
            new() { Id = Guid.NewGuid(), Name = "Snack", Description = "Botanas y aperitivos" },
        };

        context.UnitsOfMeasure.AddRange(units);
        context.Categories.AddRange(categories);
        await context.SaveChangesAsync();
    }
}
