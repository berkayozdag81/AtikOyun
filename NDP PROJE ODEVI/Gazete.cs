using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class Gazete : Atik //Atik sınıfından miras alan ve onun özelliklerini override eden Gazete sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }

        public Gazete() // Gazete sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Gazete";
            this.Hacim = 250;
            this.Image = Image.FromFile("gazete.jpg");
        }
    }
}
