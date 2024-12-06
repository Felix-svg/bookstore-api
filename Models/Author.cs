using System;
using System.Text.Json.Serialization;

namespace BookStoreAPI.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }
    [JsonIgnore]
    public List<Book> Books { get; set; } = new List<Book>();
}
