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
    public partial class YeniCariHesapDuzenle : Form
    {
        public int CariKod { get; set; }
        public YeniCariHesapDuzenle()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void YeniCariHesapDuzenle_Load(object sender, EventArgs e)
        {
            CariGrupRepository cgr = new CariGrupRepository();
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "GrupNo";
            comboBox1.DisplayMember = "GrupAdi";
            comboBox1.DataSource = cgr.GetAll();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            CariHesapRepository crep = new CariHesapRepository();
            CariHesap c = crep.GetRecord(x => x.CariKod == CariKod);

            c.Unvan = textBox1.Text;
            #region Resim
            c.Grup =(CariGrup)comboBox1.SelectedItem;
            MemoryStream okuyucu = new MemoryStream();
            pictureBox1.Image.Save(okuyucu, ImageFormat.Jpeg);
            c.Resim = okuyucu.ToArray();
            #endregion

            #region Ticari
            c.TicariBilgiler.TCKimlikNo = Convert.ToInt64(maskedTextBox1.Text);
            c.TicariBilgiler.VergiNo =Convert.ToInt64(maskedTextBox2.Text);
            c.TicariBilgiler.VergiDairesi = textBox2.Text;
            c.TicariBilgiler.KDVNo = textBox3.Text;
            #endregion

            #region Iletisim
            c.IletisimBilgileri.Adres = textBox4.Text;
            c.IletisimBilgileri.Telefon = maskedTextBox3.Text;
            c.IletisimBilgileri.Eposta = textBox5.Text;
            c.IletisimBilgileri.Website = textBox7.Text;
            c.IletisimBilgileri.IlgiliKisi = textBox6.Text;
            #endregion

            #region Kefil
            c.KefilBilgileri.AdSoyad = textBox8.Text;
            c.KefilBilgileri.Adres = textBox9.Text;
            c.KefilBilgileri.Telefon = maskedTextBox5.Text;
            #endregion

            #region Banka
            c.BankaHesapBilgileri.BankaAdi = textBox10.Text;
            c.BankaHesapBilgileri.Sube = textBox11.Text;
            c.BankaHesapBilgileri.SubeKodu = textBox12.Text;
            c.BankaHesapBilgileri.HesapNo = textBox13.Text;
            c.BankaHesapBilgileri.IBAN = maskedTextBox7.Text;
            #endregion

            crep.Update(c);
            Program.RefreshAllForms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            pictureBox1.Image = Image.FromFile(o.FileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
