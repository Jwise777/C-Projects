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

            Console.WriteLine(numArray[3]);
            Console.ReadLine();

            string[] stringArray1 = new int[] { "blue, Red, green, yellow, orange" };

            Console.WriteLine(stringArray1);
            Console.ReadLine();


            //My list of strings//
            List<string> intList = new List<string>();
            intList.Add("Good");
            intList.Add("Afternoon");
            intList.Add("Tech Academy Students!");
        }
    }
}
