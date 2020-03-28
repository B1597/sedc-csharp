using System;

namespace Task02
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string Eat()
        {
            string eating = $"{Name} the {Race} is now eating.";
            return eating;
        }

        public string Play()
        {
            string playing = $"{Name} the {Race} is now playing.";
            return playing;
        }

        public string ChaseTail()
        {
            string chaseTail = $"{Name} the {Race} is now chasing his tail.";
            return chaseTail;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dog doggo = new Dog();

            Console.Write("Write dog's name: ");
            doggo.Name = Console.ReadLine();

            Console.Write("Write dog's race: ");
            doggo.Race = Console.ReadLine();

            Console.Write("Write dog's color: ");
            doggo.Color = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Choose one of the actions");
            Console.WriteLine("1) Eating");
            Console.WriteLine("2) Playing");
            Console.WriteLine("3) Chasing tail");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine(doggo.Eat());
            }
            else if (input == "2")
            {
                Console.WriteLine(doggo.Play());
            }
            else if (input == "3")
            {
                Console.WriteLine(doggo.ChaseTail());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
