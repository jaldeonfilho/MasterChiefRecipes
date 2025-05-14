using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Service.Interfaces
{
    public interface IRecipeService
    {
        Recipe GetRecipeById(int recipeId);
        void AddRecipe(Recipe recipe);
        void ApproveRecipe(int recipeId);
        IEnumerable<Recipe> GetPendingRecipes();
        IEnumerable<Recipe> GetAllRecipes();
    }
}
