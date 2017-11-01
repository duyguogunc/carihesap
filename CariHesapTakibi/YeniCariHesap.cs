using BusinessLogic;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    public partial class YeniCariHesap : BaseForm
    {
        public YeniCariHesap()
        {
            InitializeComponent();
        }

        public override void RefreshForm()
        {
            CariGrupRepository cgr = new CariGrupRepository();
            cmb_Grup.DataSource = null;
            cmb_Grup.ValueMember = "GrupNo";
            cmb_Grup.DisplayMember = "GrupAdi";
            cmb_Grup.DataSource = cgr.GetAll();
            
        }

        private void YeniCariHesap_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Entity'i oluştur
            CariHesap firmaKaydi = new CariHesap();

            #region Genel
            firmaKaydi.Unvan = txt_Unvan.Text;
            firmaKaydi.Grup = (CariGrup)cmb_Grup.SelectedItem;

            #region Resim
            //memory stream bellekte bir dosyayı tutmamıza veya olan dosyayı okumamıza yarar
            //birşeyleri byte dizisine çevirmemizi kolaylaştırır
            MemoryStream bellekOkuyucu = new MemoryStream();
            //resmi bellege kaydediyoruz
            p_Resim.Image.Save(bellekOkuyucu, ImageFormat.Jpeg);
            firmaKaydi.Resim = bellekOkuyucu.ToArray();
            #endregion

            #endregion

            #region Ticari

            Ticari t = new Ticari();
            t.SahisFirmasiMi = chk_SahisFirma.Checked;
            t.YabanciMi = chk_YabanciUyruk.Checked;
            try 
            {
                t.VergiNo = Convert.ToInt64(msk_VergiNo.Text);
            }
            catch { } 
            long gecici;
            long.TryParse(msk_TC.Text, out gecici);
            t.TCKimlikNo = gecici;
            t.KDVNo = txt_KDVNo.Text;
            t.VergiDairesi = txt_VergiDairesi.Text;
            firmaKaydi.TicariBilgiler = t;
            #endregion

            #region Iletisim
            firmaKaydi.IletisimBilgileri = new Iletisim();
            firmaKaydi.IletisimBilgileri.Adres = txt_IletisimAdres.Text;
            firmaKaydi.IletisimBilgileri.Telefon = msk_IletisimTel.Text;
            firmaKaydi.IletisimBilgileri.Eposta = txt_IletisimEmail.Text;
            firmaKaydi.IletisimBilgileri.Website = txt_IletisimWeb.Text;
            firmaKaydi.IletisimBilgileri.IlgiliKisi = txt_Ilgili1.Text;
            #endregion

            #region Kefil 
            firmaKaydi.KefilBilgileri = new Kefil();
            firmaKaydi.KefilBilgileri.Adres = txt_KefilAdres.Text;
            firmaKaydi.KefilBilgileri.AdSoyad = txt_KefilAdSoyad.Text;
            firmaKaydi.KefilBilgileri.Telefon = msk_KefilTel.Text;
            #endregion

            #region Banka
            firmaKaydi.BankaHesapBilgileri = new BankaHesap();
            firmaKaydi.BankaHesapBilgileri.BankaAdi = txt_BankaAd.Text;
            firmaKaydi.BankaHesapBilgileri.HesapNo = txt_BankaHesapNo.Text;
            firmaKaydi.BankaHesapBilgileri.IBAN = msk_BankaIban.Text;
            firmaKaydi.BankaHesapBilgileri.Sube = txt_BankaSubeAd.Text;
            firmaKaydi.BankaHesapBilgileri.SubeKodu = txt_BankaSubeKod.Text;
            #endregion

            //Kayıtları ekleyebilen, silebilen, getirebilen yöneticiyi oluştur
            CariHesapRepository cariYonetici = new CariHesapRepository();
            cariYonetici.Add(firmaKaydi);
            Program.RefreshAllForms();
        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            //1- Resim seçmek için OpenFileDialog açılsın
            OpenFileDialog o = new OpenFileDialog();
            //2- Bir resim seçelim
            o.ShowDialog();
            //3- Picturebox'ta gösterilsin.
            p_Resim.Image =Image.FromFile( o.FileName);
            p_Resim.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}