using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CariHesapRepository : BaseRepository<CariHesap>
    {
        public override void Add(CariHesap record)
        {
            if (Liste != null && Liste.Count != 0)
                record.CariKod = Liste.Last().CariKod + 1;
            else
                record.CariKod = 1;
            base.Add(record);
        }

        public List<CariHesapViewModel> CariRapor()
        {
            /*
            List<CariHesapViewModel> liste = new List<CariHesapViewModel>();
            foreach (var item in Liste){
                CariHesapViewModel c = new CariHesapViewModel();
                c.Unvan = ...
                liste.Add(c);
            }
            return liste;
             */

            return Liste.Select(x => new CariHesapViewModel()
            {
                CariKod = x.CariKod,
                IlgiliKisi = x.IletisimBilgileri.IlgiliKisi,
                Resim = x.Resim,
                Telefon = x.IletisimBilgileri.Telefon,
                Unvan = x.Unvan
            }).ToList();
        }
        public HesapHareketiCariViewModel HesapHareketiCari(CariHesap gelenHesap)
        {
            HesapHareketiCariViewModel h = new HesapHareketiCariViewModel();
            var gelen = Liste.Where(x => x.CariKod == gelenHesap.CariKod).FirstOrDefault();
            //return Liste.Select(x => new HesapHareketiCariViewModel()
            
            h.CariKod = gelen.CariKod;
            h.Unvan = gelen.Unvan;            
            h.Grup = gelen.Grup.GrupAdi;
            h.TicariBilgiler = gelen.TicariBilgiler.VergiNo;
            h.IletisimBilgileri = gelen.IletisimBilgileri.IlgiliKisi;
            h.BankaHesapBilgileri = gelen.BankaHesapBilgileri.IBAN;
            h.KefilBilgileri = gelen.KefilBilgileri.AdSoyad;
            return h;      
            //).ToList();
        }
    
    }
    public class CariGrupRepository : BaseRepository<CariGrup>
    {
        public override void Add(CariGrup record)
        {
            if (Liste != null && Liste.Count != 0)
                record.GrupNo = Liste.Last().GrupNo + 1;
            else
                record.GrupNo = 1;
            base.Add(record);
        }
    }
    public class HesapHareketRepository : BaseRepository<HesapHareket>
    {
        public override void Add(HesapHareket record)
        {
            if (Liste != null && Liste.Count != 0)
                record.CHHNo = Liste.Last().CHHNo + 1;
            else
                record.CHHNo = 1;
            base.Add(record);
        }
       
    public List<HesapHareketiViewModel> HesapHareketiRaporAy(string ay,string yil)
        {
            return Liste.Where(a=>a.IslemTarihi.Month.ToString()==ay && a.IslemTarihi.Year.ToString()==yil).Select(x => new HesapHareketiViewModel()
            {
                CHHNo = x.CHHNo,
                CariHesabi = x.CariHesabi.Unvan,
                IslemTarihi = x.IslemTarihi,
                Tutar = x.Tutar,
                IslemTipi = x.IslemTipi,
                
            }).ToList();
        }

        public List<HesapHareketiViewModel> HesapHareketiRaporGun(DateTime gun)
        {
            return Liste.Where(a => a.IslemTarihi.Day == gun.Day && a.IslemTarihi.Month == gun.Month && a.IslemTarihi.Year == gun.Year).Select(x => new HesapHareketiViewModel()
            {
                CHHNo = x.CHHNo,
                CariHesabi = x.CariHesabi.Unvan,
                IslemTarihi = x.IslemTarihi,
                Tutar = x.Tutar,
                IslemTipi = x.IslemTipi,
            }).ToList();
        }

        public List<HesapHareketiViewModel> HesapHareketiRapor()
        {
            return Liste.Select(x => new HesapHareketiViewModel()
            {
                CHHNo = x.CHHNo,
                CariHesabi = x.CariHesabi.Unvan,
                IslemTarihi = x.IslemTarihi,
                Tutar = x.Tutar,
                IslemTipi = x.IslemTipi,
                VadeGunu=x.VadeGunu
            }).ToList();
        }
        public void CariGoruntule()
        {
            Liste.Select(x => new HesapHareket()
            {
                CHHNo = x.CHHNo,
                CariKodu = x.CariKodu,
                CariHesabi = x.CariHesabi,
                IslemTarihi = x.IslemTarihi,
                VadeTarihi = x.VadeTarihi,
                Evrak = x.Evrak,
                VadeGunu = x.VadeGunu,
            }).ToList();
        }

       
    }
}
