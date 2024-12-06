using BookStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET /api/customers
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = AppDBContext._customersList;
            if (!customers.Any())
            {
                return NoContent();
            }
            return Ok(customers);
        }

        // GET /api/customers/{id}
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = AppDBContext._customersList.Find(customer => customer.Id == id);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            return Ok(customer);
        }

        // POST /api/customers
        [HttpPost]
        public IActionResult PostCustomer([FromBody] Customer newCustomer)
        {
            newCustomer.Id = AppDBContext._customersList.Count + 1;
            newCustomer.PurchasedBooks = new List<Book>();
            AppDBContext._customersList.Add(newCustomer);
            return CreatedAtAction(nameof(GetCustomer), new{id =newCustomer.Id}, newCustomer);
        }

        // PUT /api/customers/{id}
        [HttpPut("{id}")]
        public IActionResult PutCustomer([FromBody] Customer updatedCustomer, int id)
        {
            var customerOld = AppDBContext._customersList.Find(customer => customer.Id == id);
            if (customerOld == null)
            {
                return NotFound("Customer not found");
            }
            customerOld.Name = updatedCustomer.Name;
            customerOld.Email = updatedCustomer.Email;
            
            return Ok(customerOld);
        }

        // DELETE /api/customers/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = AppDBContext._customersList.Find(customer => customer.Id == id);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            AppDBContext._customersList.Remove(customer);
            return Ok(customer);
        }

        // POST /api/customers/{customerId}/{bookId}
        [HttpPost("{customerId}/{bookId}")]
        public IActionResult PurchaseBook(int customerId, int bookId)
        {
            var customer = AppDBContext._customersList.Find(customer => customer.Id == customerId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }

            var book = AppDBContext._booksList.Find(book => book.Id == bookId);
            if (book == null)
            {
                return NotFound("Book not found");
            }

            if (customer.PurchasedBooks.Any(b => b.Id == bookId))
            {
                return BadRequest("Customer already owns this book");
            }
            customer.PurchasedBooks.Add(book);
            return Ok(customer);
        }
    }
}
