using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 01
            Console.WriteLine("EXERCISE 01:");

            double one = 6.2;
            double two = 8.3;
            double result = one / two;

            int num1 = 26;
            int num2 = 4;
            int intResult = num1 / num2;

            Console.WriteLine(result);
            Console.WriteLine(intResult);


            //EXERCISE 02
            Console.WriteLine("EXERCISE 02:");

            string name = "Bojana";
            string surname = "Dimovikj";
            string fullName = name + " " + surname;

            string nine = "9";
            string three = "3";
            string concatenated = nine + three;

            Console.WriteLine(fullName);
            Console.WriteLine(concatenated);


            //EXERCISE 03
            Console.WriteLine("EXERCISE 03:");

            int seven = 7;
            string seventy = "70";
            string concatenated2 = seven + seventy;

            Console.WriteLine(concatenated2);


            //EXERCISE 04
            Console.WriteLine("EXERCISE 04:");

            int n = 120;
            int m = 5;
            int howMany = n / m;

            Console.WriteLine(howMany);


            //EXERCISE 05
            Console.WriteLine("EXERCISE 05:");

            Console.WriteLine("Enter a number of trees");
            string numOfTrees = Console.ReadLine();
            int trees = int.Parse(numOfTrees);


            int branches = 12;
            int apples = 8;
            int basketApples = 5;

            int total = trees * branches * apples;

            int basket = 0;

            if (total % basketApples == 0)
            {
                basket = total / basketApples;
            } else
            {
                basket = (total / basketApples) +1;
            }

            Console.WriteLine(basket);


            //EXERCISE 06
            Console.WriteLine("EXERCISE 06:");

            Console.WriteLine("Enter a number");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Enter a second number");
            string secondNum = Console.ReadLine();

            int numOne = int.Parse(firstNum);
            int numTwo = int.Parse(secondNum);
            int bigger;

            if(numOne > numTwo)
            {
                bigger = numOne;
                Console.WriteLine(numOne + " is bigger");
            }
            else
            {
                bigger = numTwo;
                Console.WriteLine(numTwo + " is bigger");
            }

            
            if(bigger % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }


            //EXERCISE 07
            Console.WriteLine("EXERCISE 07:");

            Console.WriteLine("Enter a number from 1-3");
            string input = Console.ReadLine();
            int transport = int.Parse(input);
            
            switch(transport)
            {
                case 01:
                    Console.WriteLine("You got a new car!");
                    break;
                case 02:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 03:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1-3");
                    break;
            }     

            Console.ReadLine();
        }
    }
}
