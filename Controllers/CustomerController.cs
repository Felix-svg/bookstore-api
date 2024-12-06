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

        }

        // GET /api/customers/{id}
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {

        }

        // POST /api/customers
        [HttpPost]
        public IActionResult PostCustomer([FromBody] Customer customer)
        {
            
        }

        // PUT /api/customers/{id}
        [HttpPut("{id}")]
        public IActionResult PutCustomer()
        {

        }

        // DELETE /api/customers/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {

        }

        // POST /api/customers/{customerId}/{bookId}
        [HttpPost("{customerId}/{bookId}")]
        public IActionResult PurchaseBook(int customerId, int bookId)
        {
            
        }
    }
}
