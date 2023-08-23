using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Expence:IEntity
    {
        public int Id { get; set; } //Id
        public string EmployeeId { get; set; }  //Çalışan Id
        public string Date { get; set; }  //Tarih
        public string Amount { get; set; } //Miktar

    }
}
