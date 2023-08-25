using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class ExpenceDetailDto: IDto
    {
        public string DocumentDate { get; set; }  //Döküman Tarihi
        public string Company { get; set; } //Şirket
        public double TaxRate { get; set; }  //Vergi Oranı 
        public double Total { get; set; } 
        public double TaxTotal { get; set; }  //Vergi Toplamı
    }
}
