using Repository.Context;
using Repository.Interfaces;


namespace Repository.Implementation
{
    public class CategoryRepository : GenericRepository<CategoryRepository>, ICategoryRepository
    {
        public CategoryRepository(DbContextRecipe context)
           : base(context) { }
    }
}
