using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp279
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.mathMethod(10);
            math.mathMethod(5.5m);
            math.mathMethod("10");
            Console.ReadLine();
        }
    }
}
