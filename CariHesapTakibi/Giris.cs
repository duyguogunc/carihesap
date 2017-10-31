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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_CariHesaplar_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(CariHesapListe));
            /*
            Form f = Application.OpenForms["CariHesapListe"];
            if (f == null)
                new CariHesapListe().Show();
            else
                f.Activate();
                */
        }
        private void btn_HesapHareketleri_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(HesapHareketListe));
        }
        private void btn_CariGrup_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(GrupListe));
        }
        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(Raporlar));
        }
        private void btn_Yedekler_Click(object sender, EventArgs e)
        {
            Navigation.Show(typeof(Yedekler));
        }
    }
}
