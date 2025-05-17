using Models;

namespace Service.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int userId);
        Task<User> GetUserByEmail(string email);
        string HashPassword(string password);
        Task LockUser(int userId);
        Task<bool> Login(string email, string password);
        Task ManagerPersonalInfo(int userId, string name, string email);
        void ManageUserAccess(int userId, string action);
        Task Register(User newUser);
        Task UnlockUser(int userId);
        Task Update(User user);
        bool VerifyPassword(string password, string storedHash);
    }
}
