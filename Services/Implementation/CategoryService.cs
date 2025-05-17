//using Service.Interfaces;
using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IGenericRepository<Category> repository)
            : base(repository)
        {
        }

    }
}
