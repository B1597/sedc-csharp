using System;

namespace realCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            bool calcApp = true;

            while(true)
            {
                Console.Write("Enter the operation: ");
                string operation = Console.ReadLine();

                if (operation == "s")
                {
                    Console.WriteLine("\n" + "You have not used the calculator. Thank you for the interest, try the calculation another time.",
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.WriteLine("The application will automatically close.");
                    calcApp = false;
                    break;

                }

                Console.Write("Enter the first number: ");
                string num1 = Console.ReadLine();
                int number1 = 0;

                Console.Write("Enter the second number: ");
                string num2 = Console.ReadLine();
                int number2 = 0;


                if(!int.TryParse(num1, out number1) || !int.TryParse(num2, out number2))
                {
                    Console.WriteLine("\n" + "Invalid input numbers. Please try again",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if(operation == "+")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 + number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if(operation == "-")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 - number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if(operation == "*")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 * number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if(operation == "/")
                {
                    if(number2 == 0)
                    {
                        Console.WriteLine("\n" + "Division with zero is not possible, please try again",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n" + "The result is: " + (number1 / number2),
                            Console.ForegroundColor = ConsoleColor.Green);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "Invalid operation selected, please try again.",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }    
            }



            while(calcApp)
            {
                Console.Write("Enter the operation: ",
                    Console.ForegroundColor = ConsoleColor.White);
                string operation = Console.ReadLine();

                if(operation == "s")
                {
                    Console.WriteLine("\n" + "Thank you for using the calculator. The application will automatically close.",
                        Console.ForegroundColor = ConsoleColor.Green);
                    break;
                }

                Console.Write("Enter the first number: ");
                string num1 = Console.ReadLine();
                int number1 = 0;

                Console.Write("Enter the second number: ");
                string num2 = Console.ReadLine();
                int number2 = 0;


                if(!int.TryParse(num1, out number1) || !int.TryParse(num2, out number2))
                {
                    Console.WriteLine("\n" + "Invalid input numbers. Please try again",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(operation == "+")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 + number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(operation == "-")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 - number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(operation == "*")
                {
                    Console.WriteLine("\n" + "The result is: " + (number1 * number2),
                        Console.ForegroundColor = ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(operation == "/")
                {
                    if(number2 == 0)
                    {
                        Console.WriteLine("\n" + "Division with zero is not possible, please try again",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n" + "The result is: " + (number1 / number2),
                            Console.ForegroundColor = ConsoleColor.Green);
                        Console.ReadLine();
                        Console.Clear();
                    }
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
