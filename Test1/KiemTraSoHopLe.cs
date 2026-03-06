using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH61157_632006
{
    public class KiemTraSoHopLe
    {
        public bool KiemTraSo(int n)
        {
            if (n < 1 || n > 100) return false;
            if (n % 5 == 0) return false;
            return true;
        }
    }
}
