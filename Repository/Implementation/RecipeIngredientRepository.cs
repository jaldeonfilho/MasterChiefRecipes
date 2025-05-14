using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class RecipeIngredientRepository : GenericRepository<RecipeIngredientRepository>, IRecipeIngredientRepository
    {
        public RecipeIngredientRepository(DbContextRecipe context)
           : base(context) { }
    }
}
