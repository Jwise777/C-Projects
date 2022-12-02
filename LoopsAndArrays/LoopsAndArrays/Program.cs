using System;
using System.Collections.Generic;

namespace LoopsAndArrays
{
    class Program
    {
        static void Main()
        {

            int[] numArray = new int[5];
            numArray[0] = 11;
            numArray[1] = 22;
            numArray[2] = 33;
            numArray[3] = 44;
            numArray[5] = 55;

            Console.WriteLine("Select a random number 0-5");
            string arrayChoice = Console.ReadLine();
            Console.WriteLine(arrayChoice);
            Console.ReadLine();

            string[] stringArray1 = new int[] { "blue", "Red", "green", "yellow", "orange" };

            Console.WriteLine("Select a random Color!");
            string colorChoice = Console.ReadLine();
            Console.WriteLine(colorChoice);
            Console.ReadLine();


            //My list of strings//
            List<string> intList = new List<string>();
            intList.Add("Good");
            intList.Add("Afternoon");
            intList.Add("Tech Academy Students!");
        }
    }
}
