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
    public partial class GrupListe : BaseForm
    {
        public GrupListe()
        {
            InitializeComponent();
        }
        CariGrupRepository r = new CariGrupRepository();

        public override void RefreshForm()
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "GrupAdi";
            listBox1.ValueMember = "GrupNo";
            listBox1.DataSource = r.GetAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CariGrup grup = new CariGrup();
            grup.GrupAdi = textBox1.Text;
            r.Add(grup);
            Program.RefreshAllForms();
        }
        private void GrupListe_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
