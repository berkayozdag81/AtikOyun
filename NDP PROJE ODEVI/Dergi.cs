using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class Dergi : Atik //Atik sınıfından miras alan ve onun özelliklerini override eden Dergi sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }
        public Dergi() // Dergi sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Dergi";
            this.Hacim = 200;
            this.Image = Image.FromFile("dergi.jpg");
        }
    }
}
