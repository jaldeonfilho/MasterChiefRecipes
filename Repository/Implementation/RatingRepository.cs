using Models;
using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class RatingRepository : GenericRepository<Rating>, IRatingRepository
    {
        public RatingRepository(DbContextRecipe context)
           : base(context) { }

    }
}
