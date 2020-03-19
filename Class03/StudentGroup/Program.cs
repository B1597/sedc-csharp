using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Cvetko", "Svetko", "Marko", "Sarko", "Darko" };

            Console.Write("Enter student group(there are 1 and 2): ");
            string input = Console.ReadLine();

            if(input == "1")
            {
                Console.WriteLine("The Students in G1 are:");

                foreach (string item in studentsG1)
                {
                    Console.WriteLine(item);
                }
            }
            else if(input == "2")
            {
                Console.WriteLine("The Students in G2 are:");

                foreach(string item in studentsG2)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();

        }
    }
}
