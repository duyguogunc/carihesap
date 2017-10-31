using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.BackColor = System.Drawing.Color.White;
        }

        public virtual void RefreshForm() { }
    }
}
