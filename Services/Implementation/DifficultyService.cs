using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class DifficultyService : GenericService<DifficultyDto>, IDifficultyService
    {
        public DifficultyService(IGenericRepository<DifficultyDto> repository)
            : base(repository)
        {
        }

    }
}
