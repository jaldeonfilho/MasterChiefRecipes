using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Service.Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        Category GetCategoryById(int categoryId);
        IEnumerable<Category> GetAllCategories();
        void RemoveCategory(int categoryId);
    }
}
