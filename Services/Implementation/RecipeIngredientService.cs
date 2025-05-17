using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RecipeIngredientService : GenericService<RecipeIngredient>, IRecipeIngredientService
    {
        public RecipeIngredientService(IGenericRepository<RecipeIngredient> repository)
            : base(repository)
        {
        }

    }
}
