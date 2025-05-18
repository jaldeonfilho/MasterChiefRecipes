using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class FavoriteService : GenericService<FavoriteDto>, IFavoriteService
    {
        public FavoriteService(IGenericRepository<FavoriteDto> repository)
            : base(repository)
        {
        }

    }
}
