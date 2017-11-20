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
    }
}
