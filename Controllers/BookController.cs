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

        }

        // GET /api/books/{id}
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {

        }

        // POST /api/books
        [HttpPost]
        public IActionResult PostBook([FromBody] Book book)
        {

        }

        // PUT /api/books/{id}
        [HttpPut("{id}")]
        public IActionResult PutBook([FromBody] Book book, int id)
        {

        }

        // DELETE /api/books/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {

        }
    }
}
