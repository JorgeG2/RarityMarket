using RarityMarket.Models;

namespace RarityMarket.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<bool> CreateUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<User> AuthenticateAsync(string email, string password);

    }
}
