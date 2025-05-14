using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;
using Repository.Interfaces;
using BCrypt.Net;

namespace Service.Implementation
{
    public class UserService : User, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void RegisterUser(User newUser)
        {
            // Verificar se o email já está registrado
            User existingUser = _userRepository.GetUserByEmail(newUser.Email);
            if (existingUser.Email != null)
            {
                throw new InvalidOperationException("Email já está em uso.");
            }

            newUser.Password = HashPassword(newUser.Password);
            // Adicionar o novo usuário ao repositório
            _userRepository.RegisterUser(newUser);
        }
        public bool Login(string email, string password)
        {
            // Buscar o usuário pelo email
            User user = _userRepository.GetUserByEmail(email);
            if (user.Email == null)
            {
                return false; // Usuário não encontrado
            }

            // Verificar se a senha está correta
            return VerifyPassword(password, user.Password);
        }
        public void ManagePersonalInfo(int userId, string name, string email)
        {
            // Buscar o usuário pelo ID
            User user = _userRepository.GetUserById(userId);
            if (user == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            // Atualizar as informações pessoais
            user.Name = name;
            user.Email = email;

            // Salvar as alterações no repositório
            _userRepository.UpdateUser(user);
        }
        public string HashPassword(string password)
        {
            // Verifica se a senha não é nula ou vazia
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("A senha não pode ser nula ou vazia.", nameof(password));
            }

            try
            {
                // Gera o hash da senha usando BCrypt
                return BCrypt.Net.BCrypt.HashPassword(password);
            }
            catch (Exception ex)
            {
                // Lidar com exceções inesperadas
                throw new InvalidOperationException("Erro ao gerar hash da senha.", ex);
            }
        }
        public bool VerifyPassword(string password, string storedHash)
        {
            // Verifica se a senha não é nula ou vazia
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("A senha não pode ser nula ou vazia.", nameof(password));
            }

            if (string.IsNullOrWhiteSpace(storedHash))
            {
                throw new ArgumentException("O hash da senha armazenado não pode ser nulo ou vazio.", nameof(storedHash));
            }

            try
            {
                // Verifica se a senha fornecida corresponde ao hash armazenado
                return BCrypt.Net.BCrypt.Verify(password, storedHash);
            }
            catch (Exception ex)
            {
                // Lidar com exceções inesperadas
                throw new InvalidOperationException("Erro ao verificar a senha.", ex);
            }
        }
        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }
        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }
        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        //Admin methods
        public void LockUser(int userId)
        {
            _userRepository.LockUser(userId);
        }
        public void UnlockUser(int userId)
        {
            _userRepository.UnlockUser(userId);
        }
        public void ManageUserAccess(int userId, string action)
        {
            // Logic to lock or unlock user accounts
            if (action == "lock")
                LockUser(userId);
            else
                UnlockUser(userId);
        }
    }
}
