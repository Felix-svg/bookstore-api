using System;

namespace BookStoreAPI.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<Book> PurchasedBooks { get; set; } = new List<Book>();
}
