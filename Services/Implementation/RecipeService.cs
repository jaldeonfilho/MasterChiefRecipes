using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository.Interfaces;
using Repository;

namespace Service.Implementation
{
    public class RecipeService : Recipe, IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        public Recipe GetRecipeById(int recipeId)
        {
            return _recipeRepository.GetRecipeById(recipeId);
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipeRepository.AddRecipe(recipe);
        }

        public void ApproveRecipe(int recipeId)
        {
            _recipeRepository.ApproveRecipe(recipeId);
        }

        public IEnumerable<Recipe> GetPendingRecipes()
        {
            return _recipeRepository.GetPendingRecipes();
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipeRepository.GetAllRecipes();
        }
    }
}
