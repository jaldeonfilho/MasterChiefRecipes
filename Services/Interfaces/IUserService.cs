using Models;

namespace Service.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> AddAsync(UserDto userDto);
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserDto> GetById(int userId);
        Task<UserDto> GetUserByEmail(string email);
        string HashPassword(string password);
        Task LockUser(int userId);
        Task<bool> Login(string email, string password);
        void ManageUserAccess(int userId, string action);
        Task UnlockUser(int userId);
        Task<UserDto> Update(UserDto user);
        bool VerifyPassword(string password, string storedHash);
    }
}
