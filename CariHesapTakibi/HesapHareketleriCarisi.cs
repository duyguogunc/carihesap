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
            dataGridView1.DataSource = chr.Liste.Where(x => x.CariKod == gelenHesap.CariKod).ToList();
        }
    }
}
