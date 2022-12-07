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
            int arrayChoice = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine(numArray[arrayChoice]);
            Console.ReadLine();

            string[] stringArray1 = new string[] { "blue", "Red", "green", "yellow", "orange" };

            Console.WriteLine("Select a number 0-4");
            int indexChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray1[indexChoice]);
            Console.ReadLine();


            //My list of strings//
            List<string> intList = new List<string>();
            intList.Add("Good");
            intList.Add("Afternoon");
            intList.Add("Tech Academy Students!");

            Console.WriteLine("Select a number 1-3");
            int intListChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray1[intListChoice]);
            Console.ReadLine();
        }
    }
}
