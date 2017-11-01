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
    public partial class CariHesapListe : BaseForm
    {
        public CariHesapListe() 
        {
            InitializeComponent();
        }

        public override void RefreshForm()
        {
            CariHesapRepository cariYonetici = new CariHesapRepository();
            dataGridView1.DataSource = null;
            //dataGridView1.DataSource = cariYonetici.GetAll();
            dataGridView1.DataSource = cariYonetici.CariRapor();

        }

        private void CariHesapListe_Load(object sender, EventArgs e)
        {
            RefreshForm();
        

        }

        private void btn_YeniCariHesap_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(YeniCariHesap));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //Seçili satır sayısı 0 ise 
            //Bir uyarı verelim
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Silinecek cariyi seçin");
            else
            {

            //Değilse 
            CariHesapRepository cyonetici = new CariHesapRepository();
                //cyonetici uzerinden ilgili kaydı silelim

                //CariHesap silinecek =(CariHesap) dataGridView1.SelectedRows[0].DataBoundItem;

                var id = (int)dataGridView1.SelectedRows[0].Cells["CariKod"].Value;
                CariHesap silinecek = cyonetici.Liste.Where(x => x.CariKod == id).First();

                cyonetici.Delete(silinecek);
                //RefreshForm metodu çağırılsın
                RefreshForm();

            }

        }

        private void btn_HesapHareketleri_Click(object sender, EventArgs e)
        {
            
            CariHesapRepository ch = new CariHesapRepository(); 
            var id = (int)dataGridView1.SelectedRows[0].Cells["CariKod"].Value;
            CariHesap aktarilacak = ch.Liste.Find(x => x.CariKod == id);

            CariHesapHareketleri chh = new CariHesapHareketleri();
            chh.gelenCari = aktarilacak;
            chh.Show();


           
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlemek istediğiniz hesabı seçiniz");

            }
            else
            {

                CariHesapRepository cyonetici = new CariHesapRepository();
                var id = (int)dataGridView1.SelectedRows[0].Cells["CariKod"].Value;
                CariHesap duzenlenecek = cyonetici.Liste.Where(x => x.CariKod == id).First();
                //cyonetici.Delete(duzenlenecek);
                YeniCariHesapDuzenle d = new YeniCariHesapDuzenle();
                d.CariKod = duzenlenecek.CariKod;
                d.textBox1.Text = duzenlenecek.Unvan;
                //d.comboBox1.Text =duzenlenecek.Grup.ToString();
               // d.pictureBox1.Image = (byte[])duzenlenecek.Resim;
                d.maskedTextBox1.Text = duzenlenecek.TicariBilgiler.TCKimlikNo.ToString();
                d.maskedTextBox2.Text = duzenlenecek.TicariBilgiler.VergiNo.ToString();
                d.checkBox1.Checked = duzenlenecek.TicariBilgiler.YabanciMi;
                d.checkBox2.Checked = duzenlenecek.TicariBilgiler.SahisFirmasiMi;
                d.textBox2.Text = duzenlenecek.TicariBilgiler.VergiDairesi;
                d.textBox3.Text = duzenlenecek.TicariBilgiler.KDVNo;

                d.textBox4.Text = duzenlenecek.IletisimBilgileri.Adres;
                d.maskedTextBox3.Text = duzenlenecek.IletisimBilgileri.Telefon;
                d.textBox5.Text = duzenlenecek.IletisimBilgileri.Eposta;
                d.textBox7.Text = duzenlenecek.IletisimBilgileri.Website;
                d.textBox6.Text = duzenlenecek.IletisimBilgileri.IlgiliKisi;

                d.textBox8.Text = duzenlenecek.KefilBilgileri.AdSoyad;
                d.textBox9.Text = duzenlenecek.KefilBilgileri.Adres;
                d.maskedTextBox5.Text = duzenlenecek.KefilBilgileri.Telefon;

                d.textBox10.Text = duzenlenecek.BankaHesapBilgileri.BankaAdi;
                d.textBox11.Text = duzenlenecek.BankaHesapBilgileri.Sube;
                d.textBox12.Text = duzenlenecek.BankaHesapBilgileri.SubeKodu;
                d.textBox13.Text = duzenlenecek.BankaHesapBilgileri.HesapNo;
                d.maskedTextBox7.Text = duzenlenecek.BankaHesapBilgileri.IBAN;


                Program.RefreshAllForms();
                d.Show();
                   

            }
                
        }
    }
}
