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
        string[] aylar = {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"

        };

        private void Raporlar_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                comboBox1.DataSource = aylar;
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            //if (radioButton1.Checked)
            //{
            //    comboBox1.DataSource = aylar;
            //}
            //else if (radioButton2.Checked)
            //{
            //    comboBox1.DataSource = "";
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen Mizan Seçin");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
