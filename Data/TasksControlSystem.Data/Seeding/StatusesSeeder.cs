namespace TasksControlSystem.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using TasksControlSystem.Data.Models;

    public class StatusesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Statuses.Any())
            {
                return;
            }

            await dbContext.AddAsync(new Status { Name = "Waiting" });
            await dbContext.AddAsync(new Status { Name = "Assigned to home helper" });
            await dbContext.AddAsync(new Status { Name = "Awaiting review" });
            await dbContext.AddAsync(new Status { Name = "Completed" });
            await dbContext.AddAsync(new Status { Name = "Declined" });

            await dbContext.SaveChangesAsync();
        }
    }
}
