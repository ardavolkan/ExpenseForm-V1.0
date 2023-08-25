using Business.Abstract;
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
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {

            var result = _employeeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(EmployeeDto employeeDto)
        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,

                Success = employeeDto.Success
            };
            var result = _employeeService.Add(employee);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("GetById")]
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
        public IActionResult Update(EmployeeDto employeeDto)

        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,
                EmployeePhone = employeeDto.EmployeePhone,
                Success = employeeDto.Success
            };

            var result = _employeeService.Update(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(EmployeeDto employeeDto)

        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,
                EmployeePhone = employeeDto.EmployeePhone,
                Success = employeeDto.Success
            };

            var result = _employeeService.Delete(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            var result = _employeeService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByDepartment")]
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



