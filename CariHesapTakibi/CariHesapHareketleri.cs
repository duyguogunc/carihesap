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
    public partial class CariHesapHareketleri : Form
    {
        public CariHesapHareketleri()
        {
            InitializeComponent();
        }
        public CariHesap gelenCari { get; set; }

        private void CariHesapHareketleri_Load(object sender, EventArgs e)
        {
            HesapHareketRepository hareketRep = new HesapHareketRepository();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = hareketRep.Liste.Where(x => x.CariHesabi.CariKod == gelenCari.CariKod).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = gelenCari.ToString();
        }

    }
}
