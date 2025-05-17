using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class RatingService : GenericService<Rating>, IRatingService
    {
        public RatingService(IGenericRepository<Rating> repository)
            : base(repository)
        {
        }

    }
}
