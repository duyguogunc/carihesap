using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entity.Models;
using Entity.ViewModels;

namespace CariHesapTakibi
{
    public partial class Yedekler : Form
    {
        public Yedekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseRepository<CariGrup> c = new CariGrupRepository();
            c.YedekAl();
            label1.Text = "yedek alındı";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BaseRepository<CariGrup> c = new CariGrupRepository();

                CariGrupRepository gr = new CariGrupRepository();
                CariHesapRepository cr = new CariHesapRepository();
                HesapHareketRepository hr = new HesapHareketRepository();

                var yedek = c.YedekIceAktar();

                gr.YedektenYukle(yedek.Gruplar);
                cr.YedektenYukle(yedek.Cariler);
                hr.YedektenYukle(yedek.HesapHareketleri);

                label1.Text = "Yedekten Yüklendi.";
            }
            catch
            {
                label1.Text = "Yedekler yüklenirken hata oluştu.";
            }
        }
    }
}
