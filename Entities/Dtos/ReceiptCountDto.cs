using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ReceiptCountDto:IDto
    {
        public int? Count { get; set; }
    }
}
