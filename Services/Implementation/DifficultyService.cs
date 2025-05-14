using Models;
using Repository.Interfaces;
using Service.Interfaces;


namespace Service.Implementation
{
    public class DifficultyService : IDifficultyService
    {
        private readonly IDifficultyRepository _difficultyRepository;

        public DifficultyService(IDifficultyRepository difficultyRepository)
        {
            _difficultyRepository = difficultyRepository;
        }

        public async Task AddAsync(Difficulty difficulty)
        {
            await _difficultyRepository.AddAsync(difficulty);
        }

        public async Task<IEnumerable<Difficulty>> GetAll()
        {
            return await _difficultyRepository.GetAllAsync();
        }

        public async Task<Difficulty> GetById(int id)
        {
            return await _difficultyRepository.GetByIdAsync(id);
        }

        public async Task<string> Remove(int id)
        {
            var difficulty = await GetById(id);
            if (difficulty != null)
            {
                await _difficultyRepository.Delete(difficulty);
                await _difficultyRepository.SaveAsync();
                return "Difficulty deleted with success";
            }
            else
            {
                return "Error to delete difficulty";
            }
        }
    }
}
