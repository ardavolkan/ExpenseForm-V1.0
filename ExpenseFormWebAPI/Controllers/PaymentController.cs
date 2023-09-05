﻿using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using static MongoDB.Driver.WriteConcern;

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

        [HttpPost("add")]
        public ActionResult Add(PaymentDto paymentDto)

        {
            Payment payment = new Payment()
            {
                Amount = paymentDto.Amount,
                EmployeeDepartment = paymentDto.EmployeeDepartment,
                EmployeeFirstName = paymentDto.EmployeeFirstName,
                History = paymentDto.History,
                EmployeeLastName = paymentDto.EmployeeLastName,
                Description=paymentDto.Description,
                Success = paymentDto.Success,
                CompanyName= paymentDto.CompanyName
            };
            var data = _paymentService.GetById(payment.EmployeeFirstName);
            var result = _paymentService.Delete(data.Data); ;
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

        [HttpPost("delete")]
        public ActionResult Delete(PaymentDto paymentDto)
        {
            Payment payment = new Payment()
            {
                Amount = paymentDto.Amount,
                EmployeeDepartment = paymentDto.EmployeeDepartment,
                EmployeeFirstName = paymentDto.EmployeeFirstName,
                History = paymentDto.History,
                EmployeeLastName = paymentDto.EmployeeLastName,
                Success = paymentDto.Success,
                Description = paymentDto.Description
            };
            var data = _paymentService.GetByName(payment.EmployeeFirstName);
            var result = _paymentService.Delete(data.Data); ;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public ActionResult Update(PaymentDto paymentDto)

        {
            Payment payment = new Payment()
            {
                Amount = paymentDto.Amount,
                EmployeeDepartment = paymentDto.EmployeeDepartment,
                EmployeeFirstName = paymentDto.EmployeeFirstName,
                History = paymentDto.History,
                EmployeeLastName = paymentDto.EmployeeLastName,
                Success = paymentDto.Success,
                Description = paymentDto.Description
            };

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
