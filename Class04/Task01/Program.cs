using System;

namespace Task01
{
    class Program
    {
        static void Substring()
        {
            while(true)
            {
                string sedc = "Hello from SEDC Codecademy v7.0";
                int length = sedc.Length;

                Console.WriteLine(sedc);
                Console.Write("\n" + "Enter a number: ");
                string input = Console.ReadLine();
                int number = 0;

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (number > length)
                {
                    Console.WriteLine("Enter a number between 1 and " + length);
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    string substring = sedc.Substring(0, number);
                    int newLength = substring.Length;
                    Console.WriteLine("\n" + "New string: " + substring);
                    Console.WriteLine("Length of string: " + newLength);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void Main(string[] args)
        {
            Substring();
            Console.ReadLine();
        }
    }
}
