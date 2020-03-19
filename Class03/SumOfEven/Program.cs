using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = new int[6];

            Console.Write("Enter integer no.1: ");
            array[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.2: ");
            array[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.3: ");
            array[2] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.4: ");
            array[3] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.5: ");
            array[4] = int.Parse(Console.ReadLine());

            Console.Write("Enter integer no.6: ");
            array[5] = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine("The result is: " + sum);

            Console.ReadLine();
        }
    }
}
