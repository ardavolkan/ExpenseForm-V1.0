﻿using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _employeeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(EmployeeDto employeeDto)
        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,
                EmployeeId = employeeDto.EmployeeId,
                EmployeePhone = employeeDto.EmployeePhone,  
                Success = employeeDto.Success
            };
            var result = _employeeService.Add(employee);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(string id)
        {
            var result = _employeeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Employee employee)
        {
            var result = _employeeService.Update(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Employee employee)
        {
            var result = _employeeService.Delete(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _employeeService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbydepartment")]
        public IActionResult GetByDepartment(string department)
        {
            var result = _employeeService.GetByDepartment(department);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
    }



