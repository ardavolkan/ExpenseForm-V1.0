using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
    
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenceController : ControllerBase
    {
        private readonly IExpenceService _expenceService;
        public ExpenceController(IExpenceService expenceService)
        {
            _expenceService = expenceService;           
        }

        [HttpPost("add")]
        public IActionResult Add(ExpenceDto expenceDto)
        {
            Expence expence = new Expence()
            {
                Amount = expenceDto.Amount,
                Date = expenceDto.Date,
                EmployeeDepartment = expenceDto.EmployeeDepartment,
                EmployeeFirstName = expenceDto.EmployeeFirstName,
                EmployeeLastName = expenceDto.EmployeeLastName,
                Success = expenceDto.Success
            };
            var result = _expenceService.Add(expence);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _expenceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ExpenceDto expenceDto)
        {
            Expence expence = new Expence()
            {
                Amount = expenceDto.Amount,
                Date = expenceDto.Date,
                EmployeeDepartment = expenceDto.EmployeeDepartment,
                EmployeeFirstName = expenceDto.EmployeeFirstName,
                EmployeeLastName = expenceDto.EmployeeLastName,
                Success = expenceDto.Success
            }; 

            var result = _expenceService.Update(expence);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ExpenceDto expenceDto)
        {
            Expence expence = new Expence()
            {
                Amount = expenceDto.Amount,
                Date = expenceDto.Date,
                EmployeeDepartment = expenceDto.EmployeeDepartment,
                EmployeeFirstName = expenceDto.EmployeeFirstName,
                EmployeeLastName = expenceDto.EmployeeLastName,
                Success = expenceDto.Success
            };

            var result = _expenceService.Delete(expence);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbydate")]
        public IActionResult GetByDepartment(string date)
        {
            var result = _expenceService.GetByDate(date);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyamount")]
        public IActionResult GetByAmount(string amount)
        {
            var result = _expenceService.GetByAmount(amount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _expenceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
