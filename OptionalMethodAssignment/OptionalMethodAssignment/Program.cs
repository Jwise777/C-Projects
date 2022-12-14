using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in 2 numbers, but the second number is optional!");
            Class1 math = new Class1();
            Console.WriteLine(math.mathMethod(10));
            Console.ReadLine();
        }
    }
}
