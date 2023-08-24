using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ExpenceDto: IDto
    {
        public int EmployeeId { get; set; }
        public string Date { get; set; }
    }
}
