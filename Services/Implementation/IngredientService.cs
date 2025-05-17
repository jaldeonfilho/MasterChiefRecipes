using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class IngredientService : GenericService<Ingredient>, IIngredientService
    {
        public IngredientService(IGenericRepository<Ingredient> repository)
            : base(repository)
        {
        }

    }
}
