using System;

namespace Task02
{
    class Program
    {
        static string Substract(double num1, double num2)
        {
            double result = num1 - num2;
            return "\n" + "The result is: " + result.ToString();
        }

        static string Sum(double num1, double num2)
        {
            double result = num1 + num2;
            return "\n" + "The result is: " + result.ToString();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter an operator (- or +): ",
                    Console.ForegroundColor = ConsoleColor.White);
                string oper = Console.ReadLine();


                Console.Write("Enter the first number: ");
                string num1 = Console.ReadLine();
                double number1;

                Console.Write("Enter the second number: ");
                string num2 = Console.ReadLine();
                double number2;

                if (!double.TryParse(num1, out number1) || !double.TryParse(num2, out number2))
                {
                    Console.WriteLine("\n" + "Invalid input numbers. Please try again",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (oper == "-")
                {
                    Console.WriteLine(Substract(number1, number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (oper == "+")
                {
                    Console.WriteLine(Sum(number1, number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\n" + "Invalid operation selected, please try again.",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.ReadLine();
        }
    }
}
