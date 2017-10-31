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
            hhkayit.CariHesabi = (CariHesap)cmb_CariHesap.SelectedItem;
            hhkayit.Evrak = new Evrak();
            hhkayit.Evrak.EvrakTipi =(EvrakTipi) cmb_EvrakTip.SelectedIndex + 1;
            hhkayit.Evrak.EvrakCinsi = (EvrakCinsi)cmb_EvrakCins.SelectedIndex + 1;
            hhkayit.VadeGunu = (int)nm_vadegun.Value;
            HesapHareketRepository hhYonetici = new HesapHareketRepository();
            hhYonetici.Add(hhkayit);
            Program.RefreshAllForms();
        }
    }
}
