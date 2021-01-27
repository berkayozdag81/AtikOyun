using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
    interface IAtik //atıkların miras alması için oluşturduğum interface.
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }
}
