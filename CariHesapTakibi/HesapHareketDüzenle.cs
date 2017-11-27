using BusinessLogic;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    public partial class HesapHareketDüzenle : Form
    {
        
        internal HesapHareket SecilenHesap { get; set; }
        public HesapHareketDüzenle()
        {
            InitializeComponent();
        }

        private void HesapHareketDüzenle_Load(object sender, EventArgs e)
        {
            if (SecilenHesap != null)
            {
                cb_CariHesap.DataSource = null;
                cb_CariHesap.DisplayMember = "Unvan";
                cb_CariHesap.ValueMember = "CariKod";
                cb_CariHesap.DataSource = new CariHesapRepository().GetAll();

                string[] cinsler = Enum.GetNames(typeof(EvrakCinsi));
                cb_EvrakCinsi.DataSource = cinsler;

                FieldInfo[] alanlar = typeof(EvrakTipi).GetFields();
                List<string> tipler = new List<string>();
                foreach (var alan in alanlar)
                {
                    try
                    {
                        tipler.Add(alan.GetCustomAttribute<DescriptionAttribute>().Description);
                    }
                    catch { }
                }
                cb_EvrakTipi.DataSource = tipler;


                cb_CariHesap.SelectedItem = SecilenHesap.CariHesabi.Unvan;
                nm_Tutar.Value = SecilenHesap.Tutar;
                if (SecilenHesap.IslemTipi==IslemTipi.NakitTahsilat)
                {
                    rb_NakitTahsilat.Checked = true;
                }
                else if (SecilenHesap.IslemTipi==IslemTipi.NakitTediye)
                {
                    rb_NakitTediye.Checked = true;
                }
                dtp_IslemTarihi.Value = SecilenHesap.IslemTarihi;
                dtp_VadeTarihi.Value = SecilenHesap.VadeTarihi;
                nm_VadeGunu.Value = SecilenHesap.VadeGunu;
                txt_EvrakNo.Text = SecilenHesap.Evrak.EvrakNo.ToString();


            }
        }
        public int Chhno { get; set; }
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            HesapHareketRepository hhYonetici = new HesapHareketRepository();
            HesapHareket hhkayit = hhYonetici.GetRecord(x => x.CHHNo ==Chhno);
            hhkayit.CariKodu = Convert.ToInt32(cb_CariHesap.SelectedValue);
            hhkayit.CariHesabi = (CariHesap)cb_CariHesap.SelectedItem;
            hhkayit.Tutar = nm_Tutar.Value;
            if (rb_NakitTahsilat.Checked)
            {
                hhkayit.IslemTipi = IslemTipi.NakitTahsilat;
            }
            else if (rb_NakitTediye.Checked)
            {
                hhkayit.IslemTipi = IslemTipi.NakitTediye;
            }
            hhkayit.IslemTarihi = dtp_IslemTarihi.Value;
            hhkayit.VadeTarihi = dtp_VadeTarihi.Value;

            hhkayit.VadeGunu = (int)nm_VadeGunu.Value;
            hhkayit.Evrak = new Evrak();
            hhkayit.Evrak.EvrakNo = txt_EvrakNo.Text == String.Empty ? 0 : Convert.ToInt32(txt_EvrakNo.Text);
            hhkayit.Evrak.EvrakTipi = (EvrakTipi)cb_EvrakTipi.SelectedIndex + 1;
            hhkayit.Evrak.EvrakCinsi = (EvrakCinsi)cb_EvrakCinsi.SelectedIndex + 1;

            
            hhYonetici.Update(hhkayit);
            Program.RefreshAllForms();
            MessageBox.Show("Eklendi!");
        }

        private void nm_VadeGunu_ValueChanged(object sender, EventArgs e)
        {
            dtp_VadeTarihi.Value = ((DateTime)dtp_VadeTarihi.Value).AddDays((double)nm_VadeGunu.Value);
            dtp_IslemTarihi.Refresh();
        }
    }
}
