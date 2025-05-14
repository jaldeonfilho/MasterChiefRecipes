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
    public class RecipeCategoryService : IRecipeCategoryService
    {
        private readonly IRecipeCategoryRepository _recipeCategoryRepository;

        public RecipeCategoryService(IRecipeCategoryRepository recipeCategoryRepository)
        {
            _recipeCategoryRepository = recipeCategoryRepository;
        }

        public void AddRecipeCategory(RecipeCategory recipeCategory)
        {
            _recipeCategoryRepository.AddRecipeCategory(recipeCategory);
        }

        public RecipeCategory GetRecipeCategoryById(int recipeCategoryId)
        {
            return _recipeCategoryRepository.GetRecipeCategoryById(recipeCategoryId);
        }

        public IEnumerable<RecipeCategory> GetAllRecipeCategories()
        {
            return _recipeCategoryRepository.GetAllRecipeCategories();
        }

        public void UpdateRecipeCategory(RecipeCategory recipeCategory)
        {
            _recipeCategoryRepository.UpdateRecipeCategory(recipeCategory);
        }

        public void RemoveRecipeCategory(int recipeCategoryId)
        {
            _recipeCategoryRepository.RemoveRecipeCategory(recipeCategoryId);
        }
    }
}
