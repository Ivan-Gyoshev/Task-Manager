namespace DoYourThings.Services.Categories
{
    using System.Linq;

    using DoYourThings.Data;

    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext dbContext;

        public CategoriesService(ApplicationDbContext dbContext) 
            => this.dbContext = dbContext;

        public bool GetById(string id) 
            => this.dbContext.Categories.Any(c => c.Id != id);
    }
}
