using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class HesapHareketiCariViewModel
    {
        
        public int CariKod { get; set; }
        public string Unvan { get; set; }
        
        public string Grup { get; set; }
        public long TicariBilgiler { get; set; }
        public string IletisimBilgileri { get; set; }
        public string BankaHesapBilgileri { get; set; }
        public string KefilBilgileri { get; set; }

    }
}
