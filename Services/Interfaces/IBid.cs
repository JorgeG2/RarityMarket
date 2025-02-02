using RarityMarket.Models;

namespace RarityMarket.Services.Interfaces
{
    public interface IBid
    {
        Task<bool> PlaceBidAsync(int auctionId, Bid bid);
        Task<IEnumerable<Bid>> GetBidsForAuctionAsync(int auctionId);
        Task<Bid> GetHighestBidAsync(int auctionId);


    }
}
