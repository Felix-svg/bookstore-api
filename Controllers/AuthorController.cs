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

        }

        // GET /api/authors/{id}
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {

        }

        // POST /api/authors
        [HttpPost]
        public IActionResult PostAuthor([FromBody] Author author)
        {

        }

        // PUT /api/authors/{id}
        [HttpPut]
        public IActionResult PutAuthor([FromBody] Author author, int id)
        {

        }

        // DELETE /api/authors/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {

        }
    }
}
