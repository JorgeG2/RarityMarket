using RarityMarket.Models;

namespace RarityMarket.Services.Interfaces
{
    public interface IItemService
    {
        Task<Item> GetItemByIdAsync(int itemId);
        Task<IEnumerable<Item>> GetAllItemsAsync();
        Task<bool> CreateItemAsync(Item item);
        Task<bool> UpdateItemAsync(Item item);

    }
}
