using System;

namespace coffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome dear customer, please select a drink: (enter 1-5)");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3.5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1.5$");
            string input = Console.ReadLine();

            Console.WriteLine("Enter a sweetnes level: (1-5)");
            string sugar = Console.ReadLine();
            bool stopApp = true;

            while(stopApp)
            {
                if (input == "1")
                {
                    Console.WriteLine("Please insert 2$: ");
                    string monneyInput = Console.ReadLine();
                    double monney = double.Parse(monneyInput);

                    if (monney == 2)
                    {
                        Console.WriteLine("Payment successful.");
                        stopApp = false;
                    }
                    else if (monney > 2)
                    {
                        double num = monney - 2;
                        Console.WriteLine("You got " + num + "$ change.");
                        stopApp = false;
                    }
                    else if (monney < 2)
                    {
                        double num = 2 - monney;
                        Console.WriteLine("The espresso costs 2$, you are missing " + num + "$ to buy it.");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Please insert 3.5$: ");
                    string monneyInput = Console.ReadLine();
                    double monney = double.Parse(monneyInput);

                    if (monney == 3.5)
                    {
                        Console.WriteLine("Payment successful.");
                        stopApp = false;
                    }
                    else if (monney > 3.5)
                    {
                        double num = monney - 3.5;
                        Console.WriteLine("You got " + num + "$ change.");
                        stopApp = false;
                    }
                    else if (monney < 3.5)
                    {
                        double num = 3.5 - monney;
                        Console.WriteLine("The macchiato costs 3.5$, you are missing " + num + "$ to buy it.");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Please insert 4$: ");
                    string monneyInput = Console.ReadLine();
                    double monney = double.Parse(monneyInput);

                    if (monney == 4)
                    {
                        Console.WriteLine("Payment successful.");
                        stopApp = false;
                    }
                    else if (monney > 4)
                    {
                        double num = monney - 4;
                        Console.WriteLine("You got " + num + "$ change.");
                        stopApp = false;
                    }
                    else if (monney < 4)
                    {
                        double num = 4 - monney;
                        Console.WriteLine("The latte costs 4$, you are missing " + num + "$ to buy it.");
                    }
                }
                else if (input == "4")
                {
                    Console.WriteLine("Please insert 6$: ");
                    string monneyInput = Console.ReadLine();
                    double monney = double.Parse(monneyInput);

                    if (monney == 6)
                    {
                        Console.WriteLine("Payment successful.");
                        stopApp = false;
                    }
                    else if (monney > 6)
                    {
                        double num = monney - 6;
                        Console.WriteLine("You got " + num + "$ change.");
                        stopApp = false;
                    }
                    else if (monney < 6)
                    {
                        double num = 6 - monney;
                        Console.WriteLine("The cappuccino costs 6$, you are missing " + num + "$ to buy it.");
                    }
                }
                else if (input == "5")
                {
                    Console.WriteLine("Please insert 1.5$: ");
                    string monneyInput = Console.ReadLine();
                    double monney = double.Parse(monneyInput);

                    if (monney == 1.5)
                    {
                        Console.WriteLine("Payment successful.");
                        stopApp = false;
                    }
                    else if (monney > 1.5)
                    {
                        double num = monney - 1.5;
                        Console.WriteLine("You got " + num + "$ change.");
                        stopApp = false;
                    }
                    else if (monney < 1.5)
                    {
                        double num = 1.5 - monney;
                        Console.WriteLine("The tea costs 1.5$, you are missing " + num + "$ to buy it.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
