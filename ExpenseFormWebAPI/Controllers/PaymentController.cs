using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("Add")]
        public ActionResult Add(Payment payment)
        {
            var result = _paymentService.Add(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = _paymentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }



        [HttpPost("Delete")]
        public ActionResult Delete(Payment payment)
        {
            var result = _paymentService.Delete(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public ActionResult Update(Payment payment)
        {
            var result = _paymentService.Update(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(string id)
        {
            var result = _paymentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetByHistory")]
        public IActionResult GetByHistory(string history)
        {
            var result = _paymentService.GetByHistory(history);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
