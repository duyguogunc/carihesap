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
    }
}
