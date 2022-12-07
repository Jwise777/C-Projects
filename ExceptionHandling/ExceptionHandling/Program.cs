using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {      //array of integers
            int[] numArray = new int[5];
            numArray[0] = 11;
            numArray[1] = 22;
            numArray[2] = 33;
            numArray[3] = 44;
            numArray[5] = 55;
            try
            {   //asking user to input integer first then a second number
                Console.WriteLine("Pick a number 1-5");
                int numberOne = Convert.ToInt32(numArray);
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two..");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }   //exception handling for strings/zero etc
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zeo");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
