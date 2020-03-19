using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string inputOne = Console.ReadLine();

            Console.WriteLine("Enter a second number:");
            string inputTwo = Console.ReadLine();

            Console.WriteLine("Enter one of these operators: + - * /");
            string oper = Console.ReadLine();

            double num1 = double.Parse(inputOne);
            double num2 = double.Parse(inputTwo);

            if(oper == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(oper == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if(oper == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if(oper == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }            


            Console.ReadLine();
        }
    }
}
