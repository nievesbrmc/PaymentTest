using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using Business;

namespace PaymentTest.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PaymentsLogs : Controller
    {
        private readonly IPaymentTestBusiness _business;
        public PaymentsLogs(IPaymentTestBusiness business)
        {
            _business = business;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> Insert(PaymentsLog request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest();
                }
                return Ok(await _business.Insert(request));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpPut]
        public async Task<IActionResult> Update(PaymentsLog request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest();
                }
                return Ok(await _business.Update(request));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetItem(long? Id)
        {
            try
            {
                if (!Id.HasValue)
                {
                    return BadRequest();
                }
                return Ok(await _business.GetItem(Id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    try
        //    {
        //        return Ok(await _business.GetAll());
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex);
        //    }
        //}
    }
}
