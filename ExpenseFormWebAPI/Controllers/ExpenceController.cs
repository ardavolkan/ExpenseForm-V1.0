﻿using Business.Abstract;
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
        public IActionResult Add(ExpenceDto expenceDto)
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
        public IActionResult GetById(string id)
        {
            var result = _expenceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Expence expence)
        {
            var result = _expenceService.Update(expence);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Expence expence)
        {
            var result = _expenceService.Delete(expence);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByDate")]
        public IActionResult GetByDepartment(string date)
        {
            var result = _expenceService.GetByDate(date);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByAmount")]
        public IActionResult GetByAmount(string amount)
        {
            var result = _expenceService.GetByAmount(amount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAll")]
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