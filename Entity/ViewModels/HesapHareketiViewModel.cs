using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class HesapHareketiViewModel
    {
        public int CHHNo { get; set; }
        public string CariHesabi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal Tutar { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public int VadeGunu { get; set; }
    }
}
