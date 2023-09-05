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

        [HttpPost("Add")]

        public ActionResult Add(ExpenceDto expenceDto)
        {
            Expence expence = new Expence()
            {
                Amount = expenceDto.Amount,
                Date = expenceDto.Date,
                EmployeeDepartment = expenceDto.EmployeeDepartment,
                EmployeeFirstName = expenceDto.EmployeeFirstName,

                //EmployeeId = expenceDto.EmployeeId,

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

        [HttpGet("GetById")]
        public ActionResult GetById(string id)
        {
            var result = _expenceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public ActionResult Update(ExpenceDto expenceDto)

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
        public ActionResult Delete(ExpenceDto expenceDto)

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
            var data = _expenceService.GetByAmount(expence.Amount);
            var result = _expenceService.Delete(data.Data); ;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbydate")]

        public ActionResult GetByDepartment(string date)
        {
            var result = _expenceService.GetByDate(date);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyamount")]

        public ActionResult GetByAmount(string amount)
        {
            var result = _expenceService.GetByAmount(amount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]

        public ActionResult GetAll()
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
