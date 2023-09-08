using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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
        public ActionResult Add(ReceiptDto receiptDto)
        {
            Receipt receipt = new Receipt()
            {
                EmployeeDepartment = receiptDto.EmployeeDepartment,
                EmployeeFirstName = receiptDto.EmployeeFirstName,
                EmployeeLastName = receiptDto.EmployeeLastName,
                DocumentDate  = receiptDto.DocumentDate,
                Total = receiptDto.Total,
                DocumentDescription = receiptDto.DocumentDescription,
                CompanyName = receiptDto.CompanyName
            };

            var result = _receiptService.Add(receipt);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("Delete")]
        public ActionResult Delete(string id)
        {
   
            var result = _receiptService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
        [HttpPost("Update")]
        public ActionResult Update(ReceiptDto receiptDto)
        {
            Receipt receipt = new Receipt()
            {
                EmployeeDepartment = receiptDto.EmployeeDepartment,
                EmployeeFirstName = receiptDto.EmployeeFirstName,
                EmployeeLastName = receiptDto.EmployeeLastName,
                DocumentDate = receiptDto.DocumentDate,
                Total = receiptDto.Total,
                DocumentDescription = receiptDto.DocumentDescription,
                CompanyName = receiptDto.CompanyName
            };
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
        [HttpGet("GetByReceiptCount")]
        public ActionResult GetByReceiptCount()
        {
            var result = _receiptService.GetByReceiptCount();
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
