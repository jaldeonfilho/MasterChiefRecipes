using Models;
using Repository.Interfaces;
using Service.Interfaces;

namespace Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task Register(User newUser)
        {
            // Verificar se o email já está registrado
            User existingUser = await _userRepository.GetByEmail(newUser.Email);
            if (existingUser.Email != null)
            {
                throw new InvalidOperationException("Email já está em uso.");
            }

            newUser.Password = HashPassword(newUser.Password);
            // Adicionar o novo usuário ao repositório
            await _userRepository.AddAsync(newUser);
            _userRepository.SaveAsync();

        }
        public async Task<bool> Login(string email, string password)
        {
            // Buscar o usuário pelo email
            User user = await _userRepository.GetByEmail(email);
            if (user.Email == null)
            {
                return false; // Usuário não encontrado
            }

            // Verificar se a senha está correta
            return VerifyPassword(password, user.Password);
        }
        public async Task ManagerPersonalInfo(User user)
        {
            // Buscar o usuário pelo ID
            User userExist = await _userRepository.GetByIdAsync(user.Id);
            if (userExist == null)
            {
                throw new InvalidOperationException("Usuário não encontrado.");
            }

            // Atualizar as informações pessoais
            userExist.Name = user.Name;
            userExist.Email = user.Email;
            userExist.Password = HashPassword(user.Password);

            // Salvar as alterações no repositório
            _userRepository.Update(userExist);
            _userRepository.SaveAsync();
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
        public async Task<User> GetById(int userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _userRepository.GetByEmail(email);
        }
        public async Task Update(User user)
        {
            await _userRepository.Update(user);
            _userRepository.SaveAsync();
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userRepository.GetAllAsync();
        }

        //Admin methods
        public async Task LockUser(int userId)
        {
            _userRepository.LockUserAsync(userId);
        }
        public async Task UnlockUser(int userId)
        {
            _userRepository.UnlockUserAsync(userId);
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
