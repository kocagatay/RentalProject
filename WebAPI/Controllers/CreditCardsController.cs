using Business.Abstract;
using Entities.Concrete;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
         ICreditCardService _creditCardService;

        public CreditCardsController( ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCard creditCard)
        {
            var result = _creditCardService.Add(creditCard);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("getcreditcardsbycustomerid")]
        //public IActionResult GetCreditCardsByCustomerId([FromBody] int customerId)
        //{
        //    var result = _customerCreditCardService.GetSavedCreditCardsByCustomerId(customerId);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("savecreditcard")]
        //public IActionResult SaveCreditCard(CustomerCreditCardModel customerCreditCardModel)
        //{
        //    var result = _customerCreditCardService.SaveCustomerCreditCard(customerCreditCardModel);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}

        //[HttpPost("deletecreditcard")]
        //public IActionResult DeleteCreditCard(CustomerCreditCardModel customerCreditCardModel)
        //{
        //    var result = _customerCreditCardService.DeleteCustomerCreditCard(customerCreditCardModel);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }

        //    return BadRequest(result);
        //}
    }
}
