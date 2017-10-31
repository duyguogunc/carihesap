using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    static class Navigation
    {
        public static void Show(Type t)
        {
            var gelenForm = Application.OpenForms[t.Name];
            if (gelenForm == null)
            {
                /*
                switch (t.Name)
                {
                    case "CariHesapListe":
                        new CariHesapListe().Show();
                        break;
                }
                */
                Form f = (Form)Activator.CreateInstance(t);
                f.Show();
            }
            else
                gelenForm.Activate();
        }
    }
}
