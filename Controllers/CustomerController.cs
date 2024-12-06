using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET /api/customers
        // GET /api/customers/{id}
        // POST /api/customers
        // PUT /api/customers/{id}
        // DELETE /api/customers/{id}
        // POST /api/customers/{customerId}/{bookId}
    }
}
