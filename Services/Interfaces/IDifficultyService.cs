using Models;


namespace Service.Interfaces
{
    public interface IDifficultyService
    {
        Task AddAsync(Difficulty level);
        IEnumerable<Difficulty> GetAll();
        Difficulty GetById(int levelId);
        void RemoveDifficultyLevel(int levelId);
    }
}
