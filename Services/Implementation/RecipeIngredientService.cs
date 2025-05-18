using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RecipeIngredientService : GenericService<RecipeIngredientDto>, IRecipeIngredientService
    {
        public RecipeIngredientService(IGenericRepository<RecipeIngredientDto> repository)
            : base(repository)
        {
        }

    }
}
