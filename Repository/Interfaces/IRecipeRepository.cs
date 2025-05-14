using Models;
using Repository.Implementation;


namespace Repository.Interfaces
{
    public interface IRecipeRepository : IGenericRepository<RecipeRepository>
    {
        Task ApproveRecipe(int recipeId);
        Task<IEnumerable<Recipe>> GetPendingRecipes();
    }
}
