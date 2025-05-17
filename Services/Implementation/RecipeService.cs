using Models;
using Repository;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RecipeService : GenericService<Recipe>, IRecipeService
    {
        private IRecipeRepository _recipeRepository;
        public RecipeService(IGenericRepository<Recipe> repository, IRecipeRepository recipeRepository)
            : base(repository)
        {
            _recipeRepository = recipeRepository;
        }


        public async Task ApproveRecipe(int recipeId)
        {
            await _recipeRepository.ApproveRecipe(recipeId);
        }

        public async Task<IEnumerable<Recipe>> GetPendingRecipes()
        {
            var recipes = await _recipeRepository.GetPendingRecipes();
            return recipes;
        }
    }
}
