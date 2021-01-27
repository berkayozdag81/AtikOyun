using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class CamSise : Atik //Atik sınıfından miras alan ve onun özelliklerini override eden CamSise sınıfı.
    {
        public override int Hacim { get; set; }
        public override Image Image { get; }
        public string Ad { get; set; }
        public CamSise() // CamSise sınıfının kurucu fonksiyonu.Burada özelliklere değer ataması yapılır.
        {
            this.Ad = "Cam";
            this.Hacim = 600;
            this.Image = Image.FromFile("sise.jpg");
        }
    }
}
