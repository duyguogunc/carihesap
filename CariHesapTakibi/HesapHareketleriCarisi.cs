using BusinessLogic;
using Entity.Models;
using Entity.ViewModels;
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
    public class CariDetay
    {
        public string OzellikAd { get; set; }
        public string OzellikDeger { get; set; }
        public CariDetay()
        {

        }

        public CariDetay(string oAd, string oDeger)
        {
            OzellikAd = oAd;
            OzellikDeger = oDeger;
        }
    }
    public partial class HesapHareketleriCarisi : Form
    {
        public HesapHareketleriCarisi()
        {
            InitializeComponent();
        }
        internal CariHesap gelenHesap;
        private void HesapHareketleriCarisi_Load(object sender, EventArgs e)
        {
            CariHesapRepository chr = new CariHesapRepository();

            dataGridView1.DataSource = null;
            HesapHareketiCariViewModel h = chr.HesapHareketiCari(gelenHesap);
            var ozellikler = h.GetType().GetProperties();
            List<CariDetay> detay = new List<CariDetay>();
            foreach (var item in ozellikler)
                detay.Add(new CariDetay(item.Name, h.GetType().GetProperty(item.Name).GetValue(h,null).ToString()));


            dataGridView1.DataSource = detay;
            //Where(x => x.CariKod == gelenHesap.CariKod).ToList();
            string a = "";
        }
    }
}
