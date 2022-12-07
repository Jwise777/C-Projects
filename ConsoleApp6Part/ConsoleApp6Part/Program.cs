using System;
using System.Collections.Generic;

namespace ConsoleApp6Part
{
    class Program
    {
        static void Main()
        //Assignment 1 creating string array
        {  
            string[] stringArray = new string[] { "blue", "Red", "green", "yellow", "orange" };

         //Assignment 1 asking user to input text
            Console.WriteLine("Enter some random text!");
            string arrayChoice = Console.ReadLine();

            //assigment 1 for loop to add text
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += arrayChoice;
                Console.ReadLine();
            }

            //assignment 1 for each loop to display array with new text
            foreach (string color in stringArray)
            {
                Console.WriteLine(stringArray);
            }

            //assignment 3 comparison loop <
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine();
            }

            //assignment 3 comparison loop <=
            for (int i = 0; i <= stringArray.Length; i++)
            {
                Console.WriteLine();
            }

            //assignment 4 string
            string[] randomList = new string[] { "earth", "mars", "pluto", "saturn", "uranus" };

            Console.WriteLine("Search for a planet!");
            string planetChoice = Console.ReadLine();

            //assignment 4 loop to display search function with index
            for (int i = 0; i < randomList.Length; i++)
            {
                Console.WriteLine(planetChoice[i]);
            }
        }
    }
}
