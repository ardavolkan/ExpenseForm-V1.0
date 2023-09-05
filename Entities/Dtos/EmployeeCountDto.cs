using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class EmployeeCountDto:IDto
    {
        public int? Count { get; set; }
    }
}
