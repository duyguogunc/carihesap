using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CariHesapTakibi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
        }

        public static void RefreshAllForms()
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item is BaseForm)
                {
                    BaseForm b = item as BaseForm;
                    //BaseForm b =(BaseForm) item;
                    b.RefreshForm();
                }
            }
        }
    }
}
