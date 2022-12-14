using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationMethods math = new EquationMethods();
            math.mathMethod(10);
            math.mathMethod(5.5m);
            math.mathMethod("10");
            Console.ReadLine();
        }
    }
}
