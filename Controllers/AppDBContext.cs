using System;
using System.Collections.Generic;
using System.Linq;
using BookStoreAPI.Models;

namespace BookStoreAPI.Controllers
{
    public class AppDBContext
    {
        public static List<Author> _authorsList = new List<Author>();
        public static List<Book> _booksList = new List<Book>();
        public static List<Customer> _customersList = new List<Customer>();

        static AppDBContext()
        {
            _authorsList = new List<Author>
            {
                new Author { Id = 1, Name = "Bob Cohely", Bio = "Lorem Ipsum" }
            };

            _booksList = new List<Book>
            {
                new Book { Id = 1, Title = "The Archer", Genre = "Fiction", AuthorId = 1, Price = 250 }
            };

            _customersList = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Doe", Email = "johndoe@mail.com" }
            };

            foreach (var book in _booksList)
            {
                book.Author = _authorsList.Find(a => a.Id == book.AuthorId);
            }

            foreach (var author in _authorsList)
            {
                author.Books = _booksList.Where(b => b.AuthorId == author.Id).ToList();
            }

            foreach (var customer in _customersList)
            {
                customer.PurchasedBooks = _booksList.Where(b => b.AuthorId == 1).ToList();
            }
        }
    }
}
