using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class FavoriteRepository : GenericRepository<FavoriteRepository>, IFavoriteRepository
    {
        public FavoriteRepository(DbContextRecipe context)
           : base(context) { }

    }
}
