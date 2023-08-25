using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ExpenceDto: IDto
    {
        //Harcama Detayyı
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeDepartment { get; set; }
        public string Date { get; set; }  //Tarih
        public string Amount { get; set; } //Miktar
        public bool Success { get; set; }
    }
}
