using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET /api/books
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = AppDBContext._booksList;
            if (!books.Any())
            {
                return NoContent();
            }
            return Ok(books);
        }

        // GET /api/books/{id}
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = AppDBContext._booksList.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found");
            }
            return Ok(book);
        }

        // POST /api/books
        [HttpPost]
        public IActionResult PostBook([FromBody] Book newBook)
        {
            newBook.Id = AppDBContext._booksList.Count + 1;
            AppDBContext._booksList.Add(newBook);
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);
        }

        // PUT /api/books/{id}
        [HttpPut("{id}")]
        public IActionResult PutBook([FromBody] Book updatedBook, int id)
        {
            var bookOld = AppDBContext._booksList.Find(b => b.Id == id);
            if (bookOld == null)
            {
                return NotFound("Book not found");
            }
            bookOld.Title = updatedBook.Title;
            bookOld.Genre = updatedBook.Genre;
            bookOld.Price = updatedBook.Price;
            return Ok(bookOld);
        }

        // DELETE /api/books/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = AppDBContext._booksList.Find(b => b.Id == id);
            if (book == null)
            {
                return NotFound("Book not found");
            }
            AppDBContext._booksList.Remove(book);
            return Ok(book);
        }
    }
}
