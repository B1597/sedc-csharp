using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string inputOne = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            string inputTwo = Console.ReadLine();

            Console.WriteLine("Enter the third number");
            string inputThree = Console.ReadLine();

            Console.WriteLine("Enter the fourth number");
            string inputFour = Console.ReadLine();

            int num1 = int.Parse(inputOne);
            int num2 = int.Parse(inputTwo);
            int num3 = int.Parse(inputThree);
            int num4 = int.Parse(inputFour);

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of " + num1 + ", " + num2 + ", " + num3 + " and " + num4 + " is: " + average);

            Console.ReadLine();
        }
    }
}
