using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERSISE 01
            Console.WriteLine("EXERSISE 01:");

            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int number1 = int.Parse(input);
            int number2 = 1;

            while (number2 <= number1)
            {
                Console.WriteLine(number2);
                number2++;

            }


            Console.Write("Enter another number: ");
            string input2 = Console.ReadLine();

            int number3 = int.Parse(input2);
            int number4 = 1;

            while (number3 >= number4)
            {
                Console.WriteLine(number3);
                number3--;
            }


            //EXERSISE 02
            Console.WriteLine("EXERSISE 02:");

            Console.Write("Enter a number: ");
            string input3 = Console.ReadLine();

            int num1 = int.Parse(input3);

            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Enter another number: ");
            string input4 = Console.ReadLine();

            int num2 = int.Parse(input4);

            for (int i = 1; i <= num2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            //EXERSISE 03
            Console.WriteLine("EXERSISE 03:");

            Console.Write("Enter a number: ");
            string input5 = Console.ReadLine();

            int num3 = int.Parse(input5);

            for (int i = 1; i < num3; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }

                if (i == 100)
                {
                    Console.WriteLine("The limit is reached and stop counting.");
                    break;
                }
            }


            //EXERSISE 04
            Console.WriteLine("EXERSISE 04:");

            string[] stringArr = { "random", "words" };
            double[] doubleArr = { 26.6, 2.1 };
            char[] charArr = { '+', '-', '*', '/' };
            bool[] boolArr = { true, false };
            int[,] twoArr =
            {
                {20, 60},
                {10, 20}
            };

            Console.WriteLine(stringArr[0]);
            Console.WriteLine(doubleArr[0]);
            Console.WriteLine(charArr[3]);
            Console.WriteLine(boolArr[1]);
            Console.WriteLine(twoArr[0, 1]);

            //EXERCISE 05
            Console.WriteLine("EXERCISE 05: ");

            int[] arr = new int[5];

            Console.Write("Enter a number: ");
            arr[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number: ");
            arr[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter a third number: ");
            arr[2] = int.Parse(Console.ReadLine());

            Console.Write("Enter a fourth number: ");
            arr[3] = int.Parse(Console.ReadLine());

            Console.Write("Enter a fifth number: ");
            arr[4] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);


            //EXERCISE 06
            Console.WriteLine("EXERCISE 06: ");

            string[] names = new string[0];

            while (true)
            {
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = name;

                Console.WriteLine("Do you want to add another name (Y/N)");
                string addName = Console.ReadLine();

                if(addName == "y")
                {
                    continue;
                }
                else if(addName == "n")
                {
                    foreach(string item in names)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                else
                {
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
