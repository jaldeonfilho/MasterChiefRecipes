using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class IngredientService : GenericService<IngredientDto>, IIngredientService
    {
        public IngredientService(IGenericRepository<IngredientDto> repository)
            : base(repository)
        {
        }

    }
}
