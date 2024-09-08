using Microsoft.AspNetCore.Mvc;
using OnlineShopTest.dependency_Injection;
using OnlineShopTest.Dtos;


namespace OnlineShopTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(IUserService service) : ControllerBase
    {
        [HttpGet("customers")]
        public async Task<Customer[]> GetCustomers()
        {
            return await service.GetCustomers();
        }

        [HttpPost("add-customer")]
        public async Task<Customer> AddCustomer(AddCustomerRequest request)
        {
            return await service.AddCustomer(request);
        }
    }
}
