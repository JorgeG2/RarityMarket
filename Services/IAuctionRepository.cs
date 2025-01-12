using RarityMarket.Models;

namespace RarityMarket.Services
{
    public interface IAuctionRepository
    {
        Task<IEnumerable<Auction>> GetAuctionsAsync();
        Task<Auction> GetAuctionByIfAsync(int id);
        Task AddAuctionAsync(Auction auction);
        Task UpdateAuctionAsync(Auction auction);
        Task DeleteAuctionAsync(int id);
    }
}
