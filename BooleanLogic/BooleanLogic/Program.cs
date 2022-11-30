using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Application");
            Console.ReadLine();

            Console.WriteLine("Please answer the following questions for approval:");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int driveAge = Convert.ToInt32(age);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            string everDui = Console.ReadLine();
            bool dui = Convert.ToBoolean(everDui);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string speedTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(speedTickets);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            if (driveAge > 15 && false == dui && tickets < 3);
            {
                Console.WriteLine("You are approved for coverage!");
            }
            Console.ReadLine();
        }
    }
}
