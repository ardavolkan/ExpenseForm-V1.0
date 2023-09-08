using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class PaymentDto: IDto
    {
        //Ödeme
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public bool Success { get; set; }
        public string CompanyName { get; set; }

    }
}
