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

        public CariHesap secili { get; set; }

        private void Cari_Hesabı_Load(object sender, EventArgs e)
        {/*
            HesapHareketRepository hhr = new HesapHareketRepository();
            hhr.CariGoruntule();
            HesapHareket hh = new HesapHareket();

            lbl_carihesap.Text = hh.CariHesabi.ToString();
            lbl_evrakcinsi.Text = hh.Evrak.ToString();
            lbl_islem.Text = hh.IslemTipi.ToString();*/
            HesapHareketRepository hhr = new HesapHareketRepository();
        
            //foreach (var item in hhr.Liste)
            //{
            //    if (item is secili)
            //    {
                    lbl_evrakcinsi.Text = secili.EvrakCinsi.ToString();
                    lbl_carihesap.Text = secili.CariHesabi.Unvan.ToString();
                    lbl_evrakno.Text = secili.Evrak.EvrakNo.ToString();
                    lbl_islem.Text = secili.IslemTipi.ToString();
                    lbl_evraktipi.Text = secili.Evrak.EvrakTipi.ToString();
                    lbl_vadetarihi.Text = secili.VadeTarihi.ToString();
                    lbl_vadegünü.Text = secili.VadeGunu.ToString();
                    lbl_tutar.Text = secili.Tutar.ToString();
                    lbl_islemtarihi.Text = secili.IslemTarihi.ToString();
            //    }
               
            //}

        }
    }
}
