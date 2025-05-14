using Repository.Context;
using Repository.Interfaces;


namespace Repository.Implementation
{
    public class DifficultyRepository : GenericRepository<DifficultyRepository>, IDifficultyRepository
    {
        public DifficultyRepository(DbContextRecipe context)
           : base(context) { }

    }
}
