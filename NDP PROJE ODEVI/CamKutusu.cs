using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class CamKutusu :IAtikKutusu  //IAtikKutusu interface inden miras alan ve özelliklerini kullanan CamKutusu sınıfı.
    {
        List<Atik> camAtik = new List<Atik>();  // Cam atıklarını kutuya eklemek için oluşturduğum list.

        public int BosaltmaPuani { get; set; }

        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }

        public CamKutusu()  // kurucu fonksiyondan özelliklere değer ataması yapılır.
        {
            this.BosaltmaPuani = 600;
            this.Kapasite = 2200;
            this.DoluHacim = 0;
            this.DolulukOrani = 0;
        }


        public bool Bosalt() // cam kutusunun %75 i dolduğunda içini boşaltan fonksiyon.
        {
            if (DoluHacim > (DolulukOrani * (0.75)))
            {
                camAtik.Clear();
                this.DoluHacim = 0;
                this.DolulukOrani = 0;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)  // cam kutusunun dolu hacmi %75 in altındaysa cam türünden atıkları list e ekleyen fonksiyon.
        {
            if (Kapasite - DoluHacim > atik.Hacim)
            {
                camAtik.Add(atik);
                this.DoluHacim += atik.Hacim;
                this.DolulukOrani = Convert.ToInt32((Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite)) * 100);
                return true;
            }
            return false;
        }

    }
}
