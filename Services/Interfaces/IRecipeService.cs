using Models;

namespace Service.Interfaces
{
    public interface IRecipeService
    {
        Task ApproveRecipe(int recipeId);
        Task<IEnumerable<Recipe>> GetPendingRecipes();
    }
}
