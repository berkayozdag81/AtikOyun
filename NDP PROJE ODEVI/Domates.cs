using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class Domates : Atik //Atik sınıfından miras alan ve onun özelliklerini override eden Domates sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }

        public Domates() // Domates sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Domates";
            this.Hacim = 150;
            this.Image = Image.FromFile("domates.jpg");
        }
    }
}
