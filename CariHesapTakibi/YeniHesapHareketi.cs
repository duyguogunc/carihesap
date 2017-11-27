using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Entity.Models;

namespace CariHesapTakibi
{
    public partial class YeniHesapHareketi : BaseForm
    {
        public YeniHesapHareketi()
        {
            InitializeComponent();
        }

        public override void RefreshForm()
        {
            cmb_CariHesap.DataSource = null;
            cmb_CariHesap.DisplayMember = "Unvan";
            cmb_CariHesap.ValueMember = "CariKod";
            cmb_CariHesap.DataSource = new CariHesapRepository().GetAll();
        }

        private void YeniHesapHareketi_Load(object sender, EventArgs e)
        {
            RefreshForm();

            string[] cinsler = Enum.GetNames(typeof(EvrakCinsi));
            cmb_EvrakCins.DataSource = cinsler;

            FieldInfo[] alanlar = typeof(EvrakTipi).GetFields();
            List<string> tipler = new List<string>();
            foreach (var alan in alanlar) {
                try
                {
                    tipler.Add(alan.GetCustomAttribute<DescriptionAttribute>().Description);
                }
                catch { }
            }
            cmb_EvrakTip.DataSource = tipler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapHareket hhkayit = new HesapHareket();
            hhkayit.CariKodu = Convert.ToInt32(cmb_CariHesap.SelectedValue);
            hhkayit.CariHesabi = (CariHesap)cmb_CariHesap.SelectedItem;
            hhkayit.CariKodu = hhkayit.CariHesabi.CariKod;
            hhkayit.Tutar = nm_Tutar.Value;
            if (rb_NakitTahsilat.Checked)
            {
                hhkayit.IslemTipi = IslemTipi.NakitTahsilat;
            }
            else if (rb_NakitTediye.Checked)
            {
                hhkayit.IslemTipi = IslemTipi.NakitTediye;
            }
            hhkayit.IslemTarihi = dtp_islemtarih.Value;
            hhkayit.VadeTarihi = dtp_vadetarih.Value;

            hhkayit.VadeGunu = (int)nm_vadegun.Value;
            hhkayit.Evrak = new Evrak();
            hhkayit.Evrak.EvrakNo = txt_EvrakNo.Text == String.Empty ? 0 : Convert.ToInt32(txt_EvrakNo.Text);
            hhkayit.Evrak.EvrakTipi = (EvrakTipi)cmb_EvrakTip.SelectedIndex + 1;
            hhkayit.Evrak.EvrakCinsi = (EvrakCinsi)cmb_EvrakCins.SelectedIndex + 1;

            HesapHareketRepository hhYonetici = new HesapHareketRepository();
            hhYonetici.Add(hhkayit);
            Program.RefreshAllForms();
            MessageBox.Show("Eklendi!");
        }

        private void nm_vadegun_ValueChanged(object sender, EventArgs e)
        {
            dtp_vadetarih.Value = ((DateTime)dtp_islemtarih.Value).AddDays((double)nm_vadegun.Value);
            dtp_islemtarih.Refresh();
        }
    }
}
