using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class FavoriteService : GenericService<Favorite>, IFavoriteService
    {
        public FavoriteService(IGenericRepository<Favorite> repository)
            : base(repository)
        {
        }

    }
}
