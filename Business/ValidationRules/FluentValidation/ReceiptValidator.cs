using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ReceiptValidator:AbstractValidator<Receipt>
    {
        public ReceiptValidator()
        {
            RuleFor(p => p.DocumentDate).NotEmpty();
            RuleFor(p => p.EmployeeFirstName).NotEmpty();
            RuleFor(p => p.EmployeeLastName).NotEmpty();
            RuleFor(p=> p.EmployeeDepartment).NotEmpty();
            RuleFor(p => p.Total).NotEmpty();
            RuleFor(p => p.DocumentDate).NotEmpty();
            RuleFor(p => p.CompanyName).NotEmpty();



        }
    }
}
