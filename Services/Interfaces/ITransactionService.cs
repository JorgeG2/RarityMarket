using RarityMarket.Models;

namespace RarityMarket.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<Transaction> GetTransactionByIdAsync(int transactionId);
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
        Task<bool> CreateTransactionAsync(Transaction transaction);

    }
}
