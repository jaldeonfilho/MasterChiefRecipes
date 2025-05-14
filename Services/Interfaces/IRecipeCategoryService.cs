using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IRecipeCategoryService
    {
        public void AddRecipeCategory(RecipeCategory recipeCategory);
        public RecipeCategory GetRecipeCategoryById(int recipeCategoryId);
        public IEnumerable<RecipeCategory> GetAllRecipeCategories();
        public void UpdateRecipeCategory(RecipeCategory recipeCategory);
        public void RemoveRecipeCategory(int recipeCategoryId);

    }
}
