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
    }
}
