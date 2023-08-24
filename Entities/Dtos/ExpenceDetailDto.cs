using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ExpenceDetailDto: IDto
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string ExpenceId { get; set; }
        public string DocumentDate { get; set; }
        public string Company { get; set; }
        public double TaxRate { get; set; }
        public double Total { get; set; }
        public double TaxTotal { get; set; }
    }
}
