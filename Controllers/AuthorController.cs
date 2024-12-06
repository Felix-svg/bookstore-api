using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        // GET /api/authors
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = AppDBContext._authorsList;
            if (!authors.Any())
            {
                return NoContent();
            }
            return Ok(authors);
        }

        // GET /api/authors/{id}
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = AppDBContext._authorsList.Find(author => author.Id == id);
            if (author == null)
            {
                return NotFound("Author not found");
            }
            return Ok(author);
        }

        // POST /api/authors
        [HttpPost]
        public IActionResult PostAuthor([FromBody] Author newAuthor)
        {
            newAuthor.Id = AppDBContext._authorsList.Count + 1;
            AppDBContext._authorsList.Add(newAuthor);
            return CreatedAtAction(nameof(GetAuthor), new { id = newAuthor.Id }, newAuthor);
        }

        // PUT /api/authors/{id}
        [HttpPut]
        public IActionResult PutAuthor([FromBody] Author updatedAuthor, int id)
        {
            var authorOld = AppDBContext._authorsList.Find(author => author.Id == id);
            if (authorOld == null)
            {
                return NotFound("Author not found");
            }

            authorOld.Name = updatedAuthor.Name;
            authorOld.Bio = updatedAuthor.Bio;
            authorOld.Books = updatedAuthor.Books;
            return Ok(authorOld);
        }

        // DELETE /api/authors/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var author = AppDBContext._authorsList.Find(author => author.Id == id);
            if (author == null)
            {
                return NotFound("Author not found");
            }
            AppDBContext._authorsList.Remove(author);
            return Ok(author);
        }
    }
}
