using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCreditCardsController : ControllerBase
    {
        ICustomerCreditCardService _customerCreditCardService;

        public CustomerCreditCardsController(ICustomerCreditCardService customerCreditCardService)
        {
            _customerCreditCardService = customerCreditCardService;
        }

        [HttpPost("add")]
        public IActionResult Add(CustomerCreditCard customerCreditCardService)
        {
            var result = _customerCreditCardService.Add(customerCreditCardService);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
