using Models;

namespace Service.Interfaces
{
    public interface IRecipeService : IGenericService<RecipeDto>
    {
        Task ApproveRecipe(int recipeId);
        Task<IEnumerable<RecipeDto>> GetPendingRecipes();
    }
}
