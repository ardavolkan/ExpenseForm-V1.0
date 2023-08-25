using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private readonly IReceiptService _receiptService;
        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

        [HttpPost("Add")]
        public ActionResult Add(Receipt receipt)
        {
            var result = _receiptService.Add(receipt);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("Delete")]
        public ActionResult Delete(Receipt receipt)
        {
            var result = _receiptService.Delete(receipt);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
        [HttpPost("Update")]
        public ActionResult Update(Receipt receipt)
        {
            var result = _receiptService.Update(receipt);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
      
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = _receiptService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public ActionResult GetById(string Id)
        {
            var result = _receiptService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
