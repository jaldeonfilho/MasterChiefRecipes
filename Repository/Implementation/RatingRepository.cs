using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class RatingRepository : GenericRepository<RatingRepository>, IRatingRepository
    {
        public RatingRepository(DbContextRecipe context)
           : base(context) { }

    }
}
