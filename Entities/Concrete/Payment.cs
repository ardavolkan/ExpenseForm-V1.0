using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        public int Id { get; set; } 
        public string EmployeeId { get; set; }
        public string Amount { get; set; }
        public string PaymentChoices { get; set; }
        public string Description { get; set; }

        public string History { get; set; }
        public bool Success { get; set; }
    }
}
