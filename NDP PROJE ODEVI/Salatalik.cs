using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class Salatalik: Atik //Atik sınıfından miras alan ve onun özelliklerini override eden Salatalik sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }
        public Salatalik() // Salatalik sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Salatalık";
            this.Hacim = 120;
            this.Image = Image.FromFile("salatalık.jpg");
        }
    }
}
