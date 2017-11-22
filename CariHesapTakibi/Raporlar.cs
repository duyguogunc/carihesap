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
            dateTimePicker1.Visible = false;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hhr.HesapHareketiRaporGun(dateTimePicker1.Value);
            foreach (var item in hhr.HesapHareketiRaporGun(dateTimePicker1.Value))
            {
                if (item.IslemTipi.ToString() == "NakitTediye")
                    kasa -= item.Tutar;
                else
                    kasa += item.Tutar;

                dataGridView1.Rows[0].Cells[0].Value = kasa.ToString();
            }
            kasa = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
        }
    }
}
