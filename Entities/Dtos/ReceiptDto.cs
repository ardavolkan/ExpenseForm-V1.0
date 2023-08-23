using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ReceiptDto: IDto
    {
        public string DocumentDate { get; set; }
        public double Total { get; set; }
        public string DocumentDescription { get; set; }
        public string EmployeeId { get; set; }
        public string CompanyName { get; set; }


    }
}
