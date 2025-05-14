using Models;
using Repository.Implementation;


namespace Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserRepository>
    {
        Task<User> GetByEmail(string email);
        Task LockUserAsync(int userId);
        Task UnlockUserAsync(int userId);
        Task ManagePersonalInfoAsync(int userId, string name, string email);
        Task<User> GetByEmailIncluded(string email);
    }
}
