using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            string packageWeight = Console.ReadLine();
            int packWeight = Convert.ToInt32(packageWeight);
            Console.ReadLine();

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Your package fits under our weight requirements!");
                Console.ReadLine();

                Console.WriteLine("Please enter the package width:");
                string packageWidth = Console.ReadLine();
                int packWidth = Convert.ToInt32(packageWidth);
                Console.ReadLine();

                Console.WriteLine("Please enter the package height:");
                string packageHeight = Console.ReadLine();
                int packHeight = Convert.ToInt32(packageHeight);
                Console.ReadLine();

                Console.WriteLine("Please enter the package length:");
                string packageLength = Console.ReadLine();
                int packLength = Convert.ToInt32(packageLength);
                Console.ReadLine();

            if (packWidth + packHeight + packLength > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Your package fits under our size requirements!");
                     int totalSize = packWidth * packHeight * packLength * packWeight;
                     int totalCost = totalSize / 100;
                     Console.WriteLine("The total cost for your shipping package is:" + totalCost);
                     Console.ReadLine();
            }


            }

            
        }
    }
}
