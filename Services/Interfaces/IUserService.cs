using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Service.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(User user);
        void UpdateUser(User user);
        void LockUser(int userId);
        void UnlockUser(int userId);
        bool Login(string email, string password);
        string HashPassword(string password);
        bool VerifyPassword(string password, string storedHash);
        void ManagePersonalInfo(int userId, string name, string email);
        User GetUserById(int userId);
        User GetUserByEmail(string email);
        IEnumerable<User> GetAllUsers();     
        void ManageUserAccess(int userId, string action);
    }
}
