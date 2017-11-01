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

namespace CariHesapTakibi
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }
        HesapHareketRepository hh = new HesapHareketRepository();

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Kasa", "Kasa");
            string[] aylar = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"
            };
            comboBox1.DataSource = aylar;
        }
        decimal kasa = 0;
        HesapHareketRepository hhr = new HesapHareketRepository();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hhr.HesapHareketiRaporAy((comboBox1.SelectedIndex + 1).ToString());
                foreach (var item in hhr.HesapHareketiRaporAy((comboBox1.SelectedIndex + 1).ToString()))
                {
                    if (item.IslemTipi.ToString() == "NakitTediye")
                        kasa -= item.Tutar;
                    else
                        kasa += item.Tutar;

                    dataGridView1.Rows[0].Cells[0].Value = kasa.ToString();
                }
                kasa = 0;
            }
            
        }
    }
}
