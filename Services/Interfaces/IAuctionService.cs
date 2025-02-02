using RarityMarket.Models;

namespace RarityMarket.Services.Interfaces
{
    public interface IAuctionService
    {
        Task<IEnumerable<Auction>> GetAuctionsAsync();
        Task<Auction> GetAuctionByIfAsync(int id);
        Task AddAuctionAsync(Auction auction);
        Task UpdateAuctionAsync(Auction auction);
        Task DeleteAuctionAsync(int id);
    }
}
