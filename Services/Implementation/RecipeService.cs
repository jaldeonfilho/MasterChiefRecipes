using Models;
using Repository;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RecipeService : GenericService<RecipeDto>, IRecipeService
    {
        private IRecipeRepository _recipeRepository;
        public RecipeService(IGenericRepository<RecipeDto> repository, IRecipeRepository recipeRepository)
            : base(repository)
        {
            _recipeRepository = recipeRepository;
        }


        public async Task ApproveRecipe(int recipeId)
        {
            await _recipeRepository.ApproveRecipe(recipeId);
        }

        public async Task<IEnumerable<RecipeDto>> GetPendingRecipes()
        {
            var recipes = await _recipeRepository.GetPendingRecipes();
            return recipes;
        }
    }
}
