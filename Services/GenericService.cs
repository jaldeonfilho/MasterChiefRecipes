using Repository;

namespace Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();
        }

        public async Task AddListAsync(List<T> listEntity)
        {
            await _repository.AddListAsync(listEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.Update(entity);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await _repository.Delete(entity);
            await _repository.SaveAsync();
        }
    }

}
