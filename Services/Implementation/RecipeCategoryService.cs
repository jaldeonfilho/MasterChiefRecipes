using Models.Entities;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RecipeCategoryService : GenericService<RecipeCategory>, IRecipeCategoryService
    {
        public RecipeCategoryService(IGenericRepository<RecipeCategory> repository)
            : base(repository)
        {
        }

    }
}
