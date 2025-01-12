using System;
using System.Collections.Generic;

namespace RarityMarket.Models;

public partial class Auction
{
    public int AuctionId { get; set; }

    public int ItemId { get; set; }

    public decimal StartingPrice { get; set; }

    public DateTime EndTime { get; set; }

    public decimal? CurrentBid { get; set; }

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual Item Item { get; set; } = null!;
}
