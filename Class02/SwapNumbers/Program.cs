using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number: ");
            string inputOne = Console.ReadLine();

            Console.Write("Input the Second Number: ");
            string inputTwo = Console.ReadLine();

            int num1 = int.Parse(inputOne);
            int num2 = int.Parse(inputTwo);

            int num3 = num1;
            num1 = num2;

            
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num3);

            Console.ReadLine();
        }
    }
}
