using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class KagitKutusu: IAtikKutusu //IAtikKutusu interface inden miras alan ve özelliklerini kullanan KagitKutusu sınıfı.
    {
        List<Atik> kagitAtik = new List<Atik>(); // Kağıt atıklarını kutuya eklemek için oluşturduğum list.
        public int BosaltmaPuani { get; set; }

        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }

        public KagitKutusu() // kurucu fonksiyondan özelliklere değer ataması yapılır.
        {
            this.BosaltmaPuani = 1000;
            this.DoluHacim = 0;
            this.DolulukOrani = 0;
            this.Kapasite = 1200;
        }

        public bool Bosalt() // kağıt kutusunun %75 i dolduğunda içini boşaltan fonksiyon.
        {
            if (DoluHacim > (DolulukOrani * (0.75)))
            {
                kagitAtik.Clear();
                this.DoluHacim = 0;
                this.DolulukOrani = 0;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik) // kağıt kutusunun dolu hacmi %75 in altındaysa kağıt türünden atıkları list e ekleyen fonksiyon.
        {
            if (Kapasite - DoluHacim > atik.Hacim)
            {
                kagitAtik.Add(atik);
                this.DoluHacim += atik.Hacim;
                this.DolulukOrani = Convert.ToInt32((Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite)) * 100);
                return true;
            }
            return false;
        }
    }
}
