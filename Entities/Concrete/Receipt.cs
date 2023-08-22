using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public string CategoryName  { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
