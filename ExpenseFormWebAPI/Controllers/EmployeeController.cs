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
        public ActionResult GetAll()
        {

            var result = _employeeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Add")]
        public ActionResult Add(EmployeeDto employeeDto)
        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,
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
        [HttpGet("GetById")]
        public ActionResult GetById(string id)
        {
            var result = _employeeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public ActionResult Update(EmployeeDto employeeDto)

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
        [HttpPost("Delete")]
        public ActionResult Delete(EmployeeDto employeeDto)

        {
            Employee employee = new Employee()
            {
                EmployeeDepartment = employeeDto.EmployeeDepartment,
                EmployeeFirstName = employeeDto.EmployeeFirstName,
                EmployeeLastName = employeeDto.EmployeeLastName,
                EmployeePhone = employeeDto.EmployeePhone,
                Success = employeeDto.Success
            };

            var data = _employeeService.GetByName(employee.EmployeeFirstName);
            var result = _employeeService.Delete(data.Data);;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetByName")]
        public ActionResult GetByName(string name)
        {
            var result = _employeeService.GetByName(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByDepartment")]
        public ActionResult GetByDepartment(string department)
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



