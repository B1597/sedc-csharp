using System;

namespace trafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("STOP", Console.BackgroundColor);

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("READY", Console.BackgroundColor);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO", Console.BackgroundColor);

            Console.ReadLine();
        }
    }
}
