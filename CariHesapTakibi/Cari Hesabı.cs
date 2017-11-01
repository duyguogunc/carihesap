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

        public CariHesap secili { get; set; }

        private void Cari_Hesabı_Load(object sender, EventArgs e)
        {

            HesapHareketRepository hhr = new HesapHareketRepository();

            foreach (var item in hhr.Liste)
            {
                HesapHareketListe hhl = new HesapHareketListe();
             
                lbl_evrakcinsi.Text = item.Evrak.EvrakCinsi.ToString();
                lbl_carihesap.Text = item.CariHesabi.Unvan.ToString();
                lbl_evrakno.Text = item.Evrak.EvrakNo.ToString();
                lbl_islem.Text = item.IslemTipi.ToString();
                lbl_evraktipi.Text = item.Evrak.EvrakTipi.ToString();
                lbl_vadetarihi.Text = item.VadeTarihi.ToString();
                lbl_vadegünü.Text = item.VadeGunu.ToString();
                lbl_tutar.Text = item.Tutar.ToString();
                lbl_islemtarihi.Text = item.IslemTarihi.ToString();
                
            }



        }
    }
}
