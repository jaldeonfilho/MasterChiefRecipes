using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IRecipeIngredientService
    {
        public void AddRecipeIngredient(RecipeIngredient recipeIngredient);
        public RecipeIngredient GetRecipeIngredientById(int recipeIngredientId);
        public IEnumerable<RecipeIngredient> GetAllRecipeIngredients();
        public void UpdateRecipeIngredient(RecipeIngredient recipeIngredient);
        public void RemoveRecipeIngredient(int recipeIngredientId);
    }
}
