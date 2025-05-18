//using Service.Interfaces;
using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class CategoryService : GenericService<CategoryDto>, ICategoryService
    {
        public CategoryService(IGenericRepository<CategoryDto> repository)
            : base(repository)
        {
        }

    }
}
