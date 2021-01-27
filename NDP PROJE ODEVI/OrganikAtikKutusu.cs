using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    class OrganikAtikKutusu : IAtikKutusu //IAtikKutusu interface inden miras alan ve özelliklerini kullanan OrganikAtikKutusu sınıfı.
    {
        List<Atik> organikAtik = new List<Atik>(); // Organik  atıklarını kutuya eklemek için oluşturduğum list.
        public int BosaltmaPuani { get; set; }

        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }


        public OrganikAtikKutusu() // kurucu fonksiyondan özelliklere değer ataması yapılır.
        {
            this.Kapasite = 700;
            this.DolulukOrani = 0;
            this.DoluHacim = 0;
            this.BosaltmaPuani = 0;
        }
        public bool Bosalt() // organik atık kutusunun %75 i dolduğunda içini boşaltan fonksiyon.
        {
            if (DoluHacim > (DolulukOrani*(0.75)))
            {
                organikAtik.Clear();
                this.DoluHacim = 0;
                this.DolulukOrani = 0;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik) // organik atık kutusunun dolu hacmi %75 in altındaysa organik atık türünden atıkları list e ekleyen fonksiyon.
        {
            if (Kapasite - DoluHacim > atik.Hacim)
            {
                organikAtik.Add(atik);
                this.DoluHacim += atik.Hacim;
                this.DolulukOrani = Convert.ToInt32((Convert.ToDouble(DoluHacim) / Convert.ToDouble(Kapasite)) * 100);
                return true;
            }
            return false;
        }
    }
}
