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
            Console.WriteLine(math.mathMethod(10));
            Console.WriteLine(math.mathMethod(5.5m));
            Console.WriteLine(math.mathMethod("10"));
            Console.ReadLine();
        }
    }
}
