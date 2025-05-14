using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class RecipeCategoryRepository : GenericRepository<RecipeCategoryRepository>, IRecipeCategoryRepository
    {
        public RecipeCategoryRepository(DbContextRecipe context)
           : base(context) { }
    }
}
