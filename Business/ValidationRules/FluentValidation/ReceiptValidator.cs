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
        }
    }
}
