using Models;
using Repository;
using Service.Interfaces;


namespace Service.Implementation
{
    public class DifficultyService : GenericService<Difficulty>, IDifficultyService
    {
        public DifficultyService(IGenericRepository<Difficulty> repository)
            : base(repository)
        {
        }

    }
}
