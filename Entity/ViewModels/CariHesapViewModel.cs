using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
   public class CariHesapViewModel
    {
        public int CariKod { get; set; }
        public string Unvan { get; set; }
        public byte[] Resim { get; set; }
        public string Telefon { get; set; }
        public string IlgiliKisi { get; set; }
    }
}
