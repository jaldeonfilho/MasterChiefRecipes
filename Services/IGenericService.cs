namespace Service
{
    public interface IGenericService<T> where T : class
    {
        Task AddAsync(T entity);
        Task AddListAsync(List<T> listEntity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task UpdateAsync(T entity);
    }
}
