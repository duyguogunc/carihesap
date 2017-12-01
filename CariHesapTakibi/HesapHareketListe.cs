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
    public partial class HesapHareketListe : BaseForm
    {
        public HesapHareketListe()
        {
            InitializeComponent();
        }
        private void HesapHareketListe_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void btn_YeniHesapHareketi_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(YeniHesapHareketi));
        }

        public override void RefreshForm()
        {
            HesapHareketRepository hhr = new HesapHareketRepository();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hhr.HesapHareketiRapor();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            //Seçili satır sayısı 0 ise 
            //Bir uyarı verelim
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Silinecek hesap hareketini seçin");
            else
            {
                //Değilse 
                HesapHareketRepository hyonetici = new HesapHareketRepository();
                //cyonetici uzerinden ilgili kaydı silelim

                //CariHesap silinecek =(CariHesap) dataGridView1.SelectedRows[0].DataBoundItem;

                var id = (int)dataGridView1.SelectedRows[0].Cells["CHHNo"].Value;
                HesapHareket silinecek = hyonetici.Liste.Where(x => x.CHHNo == id).First();

                hyonetici.Delete(silinecek);

                //RefreshForm metodu çağırılsın
                RefreshForm();
            }
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Düzenlenecek Kişiyi Seçiniz");
            }
            else
            {
                int chhno = (int)dataGridView1.SelectedRows[0].Cells["CHHNo"].Value;
                HesapHareketRepository hhduzenle = new HesapHareketRepository();
                HesapHareket hh = hhduzenle.Liste.Where(x => x.CHHNo == chhno).First();
                HesapHareketDüzenle form = new HesapHareketDüzenle();
                form.Chhno = chhno;
                form.SecilenHesap=hh;
                form.Show();
            }
            
        }

        private void btn_CariHesabi_Click(object sender, EventArgs e)
        {
            CariHesapRepository cariRep = new CariHesapRepository();
            HesapHareketRepository hareketRep = new HesapHareketRepository();
            HesapHareketleriCarisi form = new HesapHareketleriCarisi();
            int CHHno = (int)dataGridView1.SelectedRows[0].Cells["CHHNo"].Value;
            HesapHareket secilenHH = (HesapHareket)hareketRep.GetRecord(x => x.CHHNo == CHHno);

            form.gelenHesap = secilenHH.CariHesabi;

            form.Show();

        }
    }
 
          
}
