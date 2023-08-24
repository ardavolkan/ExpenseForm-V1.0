using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PaymentValidator:AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.EmployeeFirstName).NotEmpty();
            RuleFor(p=>p.EmployeeFirstName).MinimumLength(2);
            RuleFor(p => p.EmployeeLastName).NotEmpty();
            RuleFor(p => p.EmployeeDepartment).NotEmpty();
            RuleFor(p => p.Amount).NotEmpty();
            RuleFor(p => p.History).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();
            RuleFor(p => p.Description).MinimumLength(20);

        }
    }
}
