using System;
using System.Collections.Generic;

namespace RarityMarket.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual ICollection<Bid> Bids { get; set; } = new List<Bid>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Transaction> TransactionBuyers { get; set; } = new List<Transaction>();

    public virtual ICollection<Transaction> TransactionSellers { get; set; } = new List<Transaction>();
}
