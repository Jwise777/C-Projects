using System;


class Program
{
   static void Main()
   {
        Console.WriteLine("The Tech Academy");
        Console.ReadLine();

        Console.WriteLine("Student Daily Report");
        Console.ReadLine();

        Console.WriteLine("What is your name?");
        string fullName = Console.ReadLine();

        Console.WriteLine("What Course are you on?");
        string currentCourse = Console.ReadLine();

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);
        Console.ReadLine();

        Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
        string helpNeeded = Console.ReadLine();
        bool helpNeed = Convert.ToBoolean(helpNeeded);
        Console.ReadLine();

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string experiences = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        byte hourStudy = Convert.ToByte(hoursStudied);
        Console.ReadLine();

        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();

   }
}
