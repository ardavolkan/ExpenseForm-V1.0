using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class EmployeeDto: IDto
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeePhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Success { get; set; }
    }
}
