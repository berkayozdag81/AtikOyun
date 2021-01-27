using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class MetalKutusu: IAtikKutusu //IAtikKutusu interface inden miras alan ve özelliklerini kullanan MetalKutusu sınıfı.
    {
        List<Atik> metalAtik = new List<Atik>(); // Metal atıklarını kutuya eklemek için oluşturduğum list.
        public int BosaltmaPuani { get; set; }

        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }


        public MetalKutusu() // kurucu fonksiyondan özelliklere değer ataması yapılır.
        {
            this.Kapasite = 2300;
            this.DolulukOrani = 0;
            this.DoluHacim = 0;
            this.BosaltmaPuani = 800;
        }
        public bool Bosalt()  // metal kutusunun %75 i dolduğunda içini boşaltan fonksiyon.
        {
            if (DoluHacim > (DolulukOrani * (0.75)))
            {
                metalAtik.Clear();
                this.DoluHacim = 0;
                this.DolulukOrani = 0;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik) // metal kutusunun dolu hacmi %75 in altındaysa metal türünden atıkları list e ekleyen fonksiyon.
        {
            if (Kapasite - DoluHacim > atik.Hacim)
            {
                metalAtik.Add(atik);
                this.DoluHacim += atik.Hacim;
                this.DolulukOrani = Convert.ToInt32((Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite)) * 100);
                return true;
            }
            return false;
        }
    }
}
