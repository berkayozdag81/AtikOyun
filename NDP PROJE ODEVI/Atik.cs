using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_PROJE_ODEVI
{
     abstract class Atik : IAtik  // IAtik ınterface inden miras alan abstract bir sınıf.
     {
        public abstract int Hacim { get; set; }

        public abstract Image Image { get; }

     }
}
