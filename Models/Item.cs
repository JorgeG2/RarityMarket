using System;
using System.Collections.Generic;

namespace RarityMarket.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    public int SellerId { get; set; }

    public virtual ICollection<Auction> Auctions { get; set; } = new List<Auction>();

    public virtual Category Category { get; set; } = null!;

    public virtual User Seller { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
