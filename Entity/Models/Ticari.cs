using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Ticari
    {
        public bool SahisFirmasiMi { get; set; }
        public bool YabanciMi { get; set; }
        public long TCKimlikNo { get; set; }
        public long VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string KDVNo { get; set; }
    }
    public class Iletisim
    {
        public string Eposta { get; set; }
        public string Website { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string IlgiliKisi { get; set; }
        public string Adres { get; set; }
    }
    public class Kefil
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
    public class BankaHesap
    {
        public string BankaAdi { get; set; }
        public string Sube { get; set; }
        public string SubeKodu { get; set; }
        public string HesapNo { get; set; }
        public string IBAN { get; set; }
    }
    public class HesapHareket
    {
        public int CHHNo { get; set; }
        public int CariKodu { get; set; }
        public CariHesap CariHesabi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public DateTime VadeTarihi { get; set; }
        public Evrak Evrak { get; set; }
        public int _vadeGunu;
        public int VadeGunu
        {
            get
            {
                return _vadeGunu;
            }
            set
            {
                if (VadeTarihi == DateTime.MinValue && value!=0)
                    VadeTarihi = IslemTarihi.AddDays(value);
                _vadeGunu = value;
            }
        }

        public IslemTipi IslemTipi { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
    }

    public class Evrak
    {
        public int EvrakNo { get; set; }
        public EvrakTipi EvrakTipi { get; set; }
        public EvrakCinsi EvrakCinsi { get; set; }
    }
    public enum EvrakTipi
    {
        [Description("Alacak Dekont")]
        AlacakDekont,
        [Description("Borç Dekontu")]
        BorcDekontu,
        [Description("Alacak Fatura")]
        AlacakFatura
    }
    public enum EvrakCinsi
    {
        Dekont,
        Fatura
    }

    public enum IslemTipi
    {
        NakitTahsilat,
        NakitTediye
    }

    public class CariHesap
    {
        public int CariKod { get; set; }
        public string Unvan { get; set; }
        public byte[] Resim { get; set; }
        public CariGrup Grup { get; set; }
        public Ticari TicariBilgiler { get; set; }
        public Iletisim IletisimBilgileri { get; set; }
        public BankaHesap BankaHesapBilgileri { get; set; }
        public Kefil KefilBilgileri { get; set; }
    }

    public class CariGrup
    {
        public int GrupNo { get; set; }
        public string GrupAdi { get; set; }
    }
}
