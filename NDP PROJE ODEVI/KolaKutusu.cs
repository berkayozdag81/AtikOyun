using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class KolaKutusu : Atik //Atik sınıfından miras alan ve onun özelliklerini override eden KolaKutusu sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }

        public KolaKutusu() // KolaKutusu sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Kola Kutusu";
            this.Hacim = 350;
            this.Image = Image.FromFile("kolaKutusu.jpg");
        }
    }
}
