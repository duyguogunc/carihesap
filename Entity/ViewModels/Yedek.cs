using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class Yedek
    {
        public List<CariGrup> Gruplar { get; set; }
        public List<CariHesap> Cariler { get; set; }
        public List<HesapHareket> HesapHareketleri { get; set; }
        
    }
}
