using System;

namespace Dowhile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 22:
                        Console.WriteLine("you guessed 22. WRONG");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 45:
                        Console.WriteLine("you guessed 45. WRONG");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 77:
                        Console.WriteLine("you guessed 77. WRONG");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed lucky number 7. Easy enough!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are always wrong");
                        break;
                }
            }
            while (!isGuessed);
        }
    }
}
