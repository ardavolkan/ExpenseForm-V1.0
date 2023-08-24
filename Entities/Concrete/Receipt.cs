using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Receipt:IEntity
    {
        public int ReceiptId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public string DocumentDate { get; set; }
        public double Total { get; set; }
        public string EmployeeId { get; set; }
        public string DocumentDescription { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }

    }
}
