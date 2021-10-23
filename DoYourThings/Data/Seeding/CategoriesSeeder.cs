namespace DoYourThings.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using DoYourThings.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Daily",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Weekly",
            });

            await dbContext.Categories.AddAsync(new Category
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Monthly",
            });
        }
    }
}
