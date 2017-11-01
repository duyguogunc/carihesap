using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Reflection;

namespace BusinessLogic
{
    //test
    //JavaScriptSerializer tarafından üretilebilir
    //JSON : JavaScript Object Notation
    // {Ad: "Duygu", Meslek: "Egitmen"}
    public abstract class JSONData<T> where T : class
    {
        public List<T> Liste { get; set; } = new List<T>();
        protected void Save()
        {
            //System.Web.Extensions referansını ekledik.
            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            string ceviri = tercuman.Serialize(Liste);

            //CariHesap.json
            //HesapHareket.json
            
            string dosyaAdi = typeof(T).ToString() + ".json";
            File.WriteAllText(dosyaAdi, ceviri);
        }
        protected void Load()
        {
            //Serialize: C# dışında bir formata çeviri (yazdırma)
            //Deserialize: C# formatına çeviri (okuma)

            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            string dosyaAdi = typeof(T).ToString() + ".json";
            if (File.Exists(dosyaAdi))
            {
                try
                {
                    string okunan = File.ReadAllText(dosyaAdi);
                    Liste = tercuman.Deserialize<List<T>>(okunan);
                }
                catch { }
            }
        }
    }
}
