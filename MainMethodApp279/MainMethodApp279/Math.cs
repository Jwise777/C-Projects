using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp279
{
    class Math
    {
        public int mathMethod(int x)
        {
            x = 10 * x;
            return x;
        }

        public int mathMethod(decimal x)
        {
            int y = Convert.ToInt32(x) - 5;
            return y;
        }

        public int mathMethod(string x)
        {
            int z = Convert.ToInt32(x) + 5;
            return z;
        }
    }
}
