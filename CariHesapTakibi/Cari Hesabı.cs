using BusinessLogic;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    public partial class Cari_Hesabı : Form
    {
        public Cari_Hesabı()
        {
            InitializeComponent();
        }
        public CariHesap secili;
        private void Cari_Hesabı_Load(object sender, EventArgs e)
        {

            HesapHareketRepository hhr = new HesapHareketRepository();
            try
            {

           
            
                HesapHareketListe hhl = new HesapHareketListe();
            txt_BankaAd.Text = secili.BankaHesapBilgileri.BankaAdi.ToString();
            txt_BankaHesapNo.Text = secili.BankaHesapBilgileri.HesapNo.ToString();
            txt_BankaSubeAd.Text = secili.BankaHesapBilgileri.Sube.ToString();
            txt_BankaSubeKod.Text = secili.BankaHesapBilgileri.SubeKodu.ToString();
            msk_BankaIban.Text = secili.BankaHesapBilgileri.IBAN.ToString();
            txt_KefilAdSoyad.Text = secili.KefilBilgileri.AdSoyad.ToString();
            txt_KefilAdres.Text = secili.KefilBilgileri.Adres.ToString();
            msk_KefilTel.Text = secili.KefilBilgileri.Telefon.ToString();
            txt_IletisimAdres.Text = secili.IletisimBilgileri.Adres.ToString();
            txt_IletisimEmail.Text = secili.IletisimBilgileri.Eposta.ToString();
            txt_IletisimWeb.Text = secili.IletisimBilgileri.Website.ToString();
            msk_IletisimTel.Text = secili.IletisimBilgileri.Telefon.ToString();
            txt_Ilgili1.Text = secili.IletisimBilgileri.IlgiliKisi.ToString();
            msk_TC.Text = secili.TicariBilgiler.TCKimlikNo.ToString();
            msk_VergiNo.Text = secili.TicariBilgiler.VergiNo.ToString();
            txt_VergiDairesi.Text = secili.TicariBilgiler.VergiDairesi.ToString();
            txt_KDVNo.Text = secili.TicariBilgiler.KDVNo.ToString();
            if (secili.TicariBilgiler.SahisFirmasiMi)
            {
                chk_SahisFirma.Checked = true;
            }
            else
            {
                chk_YabanciUyruk.Checked = true;
            }
            txt_Unvan.Text = secili.Unvan.ToString();
            cmb_Grup.Text = secili.Grup.ToString();
            p_Resim.ImageLocation = secili.Resim.ToString();
            }
            catch 
            {

            
            }



        }
    }
}
