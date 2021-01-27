using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class SalcaKutusu: Atik //Atik sınıfından miras alan ve onun özelliklerini override eden SalcaKutusu sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }
        public SalcaKutusu()  // SalcaKutusu sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Salça Kutusu";
            this.Hacim = 550;
            this.Image = Image.FromFile("salçaKutusu.jpg");
        }
    }
}
