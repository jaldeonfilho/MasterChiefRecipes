using Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class RecipeIngredientService : IRecipeIngredientService
    {
        private readonly IRecipeIngredientRepository _recipeIngredientRepository;

        public RecipeIngredientService(IRecipeIngredientRepository recipeIngredientRepository)
        {
            _recipeIngredientRepository = recipeIngredientRepository;
        }

        public void AddRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            _recipeIngredientRepository.AddRecipeIngredient(recipeIngredient);
        }

        public RecipeIngredient GetRecipeIngredientById(int recipeIngredientId)
        {
            return _recipeIngredientRepository.GetRecipeIngredientById(recipeIngredientId);
        }

        public IEnumerable<RecipeIngredient> GetAllRecipeIngredients()
        {
            return _recipeIngredientRepository.GetAllRecipeIngredients();
        }

        public void UpdateRecipeIngredient(RecipeIngredient recipeIngredient)
        {
            _recipeIngredientRepository.UpdateRecipeIngredient(recipeIngredient);
        }

        public void RemoveRecipeIngredient(int recipeIngredientId)
        {
            _recipeIngredientRepository.RemoveRecipeIngredient(recipeIngredientId);
        }
    }
}
