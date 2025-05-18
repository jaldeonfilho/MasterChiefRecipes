using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RatingService : GenericService<RatingDto>, IRatingService
    {
        public RatingService(IGenericRepository<RatingDto> repository)
            : base(repository)
        {
        }

    }
}
