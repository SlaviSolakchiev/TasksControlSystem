namespace TasksControlSystem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TasksControlSystem.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.AddAsync(new Category { Name = "Cleaning and desinfection" });
            await dbContext.AddAsync(new Category { Name = "Take care of pets and plants" });
            await dbContext.AddAsync(new Category { Name = "Take care of a child" });
            await dbContext.AddAsync(new Category { Name = "Take care of an elder" });

            await dbContext.SaveChangesAsync();
        }
    }
}
