using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class PaymentDto: IDto
    {
        public string EmployeeId { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }


    }
}
