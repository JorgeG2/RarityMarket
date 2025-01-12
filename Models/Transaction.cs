using System;
using System.Collections.Generic;

namespace RarityMarket.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int BuyerId { get; set; }

    public int SellerId { get; set; }

    public int ItemId { get; set; }

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public virtual User Buyer { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual User Seller { get; set; } = null!;
}
