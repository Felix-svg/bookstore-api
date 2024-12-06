using System;
using System.Text.Json.Serialization;

namespace BookStoreAPI.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int AuthorId { get; set; }
    public decimal Price { get; set; }
    [JsonIgnore]
    public Author Author { get; set; }
}
