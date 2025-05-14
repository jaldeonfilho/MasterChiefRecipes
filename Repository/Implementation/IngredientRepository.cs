using Repository.Context;
using Repository.Interfaces;


namespace Repository.Implementation
{
    public class IngredientRepository : GenericRepository<IngredientRepository>, IIngredientRepository
    {
        public IngredientRepository(DbContextRecipe context)
           : base(context) { }

    }
}
