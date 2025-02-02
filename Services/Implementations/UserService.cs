using RarityMarket.Services.Interfaces; // Include the namespace for IUserService
using RarityMarket.Data; // include the namespace for your dbcontext
using RarityMarket.Models; // Include the namespace for your models
using System.Threading.Tasks;

namespace RarityMarket.Services.Implementations
{
    public class UserService : IUserService
    {
        // Add required dependencies, e.g., DbContext or other services, via dependency injection.
        private readonly AppDbContext _dbContext;


    }
}
