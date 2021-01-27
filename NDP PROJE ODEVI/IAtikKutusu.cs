using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    interface IAtikKutusu :IDolabilen // IDolabilen interface inden miras alan ve atık kutularının miras alması için oluşturduğum interface.
    {
        int BosaltmaPuani { get; }
        bool Ekle(Atik atik);
        bool Bosalt();
    }
}
