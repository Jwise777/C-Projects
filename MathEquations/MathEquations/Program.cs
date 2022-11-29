using System;

namespace MathEquations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string hourlyRate = Console.ReadLine();
            int hrate = Convert.ToInt32(hourlyRate);

            Console.WriteLine("Hours worked per week?");
            string hoursWorked = Console.ReadLine();
            int hWorked = Convert.ToInt32(hoursWorked);

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly rate?");
            string hourRate = Console.ReadLine();
            int hrRate = Convert.ToInt32(hourRate);

            Console.WriteLine("Hours worked per week?");
            string hourWorked = Console.ReadLine();
            int hrWorked = Convert.ToInt32(hourWorked);

            Console.WriteLine("Annual Salary of Person 1:");
            Console.ReadLine();
            int product = hrate * hWorked * 52;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:");
            Console.ReadLine();
            int product2 = hrRate * hrWorked * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.ReadLine();

            bool trueOrFalse = product > product2;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}
