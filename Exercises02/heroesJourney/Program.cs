using System;

namespace heroesJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            bool heroesJourney = true;

            //LOG IN
            int loginAttempts = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter email: ",
                     Console.ForegroundColor = ConsoleColor.White);
                string email = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (email == "" || password == "")
                {
                    Console.WriteLine("Don't leave email or password empty! Press enter to try again...",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                    loginAttempts++;
                }
                else if(email == "bob.bobsky@mail.com" && password == "bobsky")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid email or password! Press enter to try again...",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ReadLine();
                    Console.Clear();
                    loginAttempts++;
                }
            }

            if(loginAttempts > 4)
            {
                Console.WriteLine("You tried too many times! Press enter to exit...");
                heroesJourney = false;
            }
            else
            {
                Console.WriteLine("Welcome bob.bobsky@mail.com!",
                        Console.ForegroundColor = ConsoleColor.Green);
                Console.WriteLine("Press Enter to start with character creation...");
                Console.ReadLine();
                Console.Clear();
            }

            

            //GAME FLOW
            while (heroesJourney)
            {

                bool loopName = true;
                bool loopRace = true;
                bool loopClass = true;
                bool startOver = true;
                bool event1 = true;
                bool event2 = true;
                bool event3 = true;
                bool event4 = true;
                bool event5 = true;



                //CHARACTER NAME
                string name = "";

                while (loopName)
                {
                    Console.WriteLine("Choose a name:",
                        Console.ForegroundColor = ConsoleColor.White);
                    name = Console.ReadLine();

                    if (name.Length <= 1 || name.Length > 20 || name == "")
                    {
                        Console.WriteLine("Hero name must be from 2 to 20 characters long. Press enter to try again...",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        loopName = false;
                    }
                }



                //CHARACTER RACE
                string race = "";

                while (loopRace)
                {
                    Console.WriteLine("Choose a race:",
                        Console.ForegroundColor = ConsoleColor.White);

                    Console.WriteLine("1) Dwarf");
                    Console.WriteLine("Health: 100  Strength: 6  Agility: 2" + "\n");
                    Console.WriteLine("2) Elf");
                    Console.WriteLine("Health: 60  Strength: 4  Agility: 6" + "\n");
                    Console.WriteLine("3) Human");
                    Console.WriteLine("Health: 80  Strength: 5  Agility: 4" + "\n");
                    race = Console.ReadLine();

                    if (race == "1" || race == "2" || race == "3")
                    {
                        Console.Clear();
                        loopRace = false;
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Please choose from 1-3. Press enter and try again...",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }



                //CHARACTER CLASS
                string charClass = "";

                while (loopClass)
                {
                    Console.WriteLine("Choose a class:",
                        Console.ForegroundColor = ConsoleColor.White);

                    Console.WriteLine("1) Warrior");
                    Console.WriteLine("Health: +20  Agility: -1" + "\n");
                    Console.WriteLine("2) Rogue");
                    Console.WriteLine("Health: -20  Agility: +1" + "\n");
                    Console.WriteLine("3) Mage");
                    Console.WriteLine("Health: +20  Strength: -1" + "\n");
                    charClass = Console.ReadLine();

                    if (charClass == "1" || charClass == "2" || charClass == "3")
                    {
                        Console.Clear();
                        loopClass = false;
                    }
                    else
                    {
                        Console.WriteLine("\n" + "Please choose from 1-3. Press enter and try again...",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }



                //CHARACTER STATS
                int health = 0;
                int strength = 0;
                int agility = 0;

                if (race == "1")
                {
                    race = "Dwarf";
                    health = 100;
                    strength = 6;
                    agility = 2;

                    if (charClass == "1")
                    {
                        charClass = "Warrior";
                        health = 100 + 20;
                        agility = 2 - 1;
                    }
                    else if (charClass == "2")
                    {
                        charClass = "Rogue";
                        health = 100 - 20;
                        agility = 2 + 1;
                    }
                    else if (charClass == "3")
                    {
                        charClass = "Mage";
                        health = 100 + 20;
                        strength = 6 - 1;
                    }
                }
                else if (race == "2")
                {
                    race = "Elf";
                    health = 60;
                    strength = 4;
                    agility = 6;

                    if (charClass == "1")
                    {
                        charClass = "Warrior";
                        health = 60 + 20;
                        agility = 6 - 1;
                    }
                    else if (charClass == "2")
                    {
                        charClass = "Rogue";
                        health = 60 - 20;
                        agility = 6 + 1;
                    }
                    else if (charClass == "3")
                    {
                        charClass = "Mage";
                        health = 60 + 20;
                        strength = 4 - 1;
                    }
                }
                else if (race == "3")
                {
                    race = "Human";
                    health = 80;
                    strength = 5;
                    agility = 4;

                    if (charClass == "1")
                    {
                        charClass = "Warrior";
                        health = 80 + 20;
                        agility = 4 - 1;
                    }
                    else if (charClass == "2")
                    {
                        charClass = "Rogue";
                        health = 80 - 20;
                        agility = 4 + 1;
                    }
                    else if (charClass == "3")
                    {
                        charClass = "Mage";
                        health = 80 + 20;
                        strength = 5 - 1;
                    }
                }

                Console.WriteLine("Character successfully created!" + "\n",
                    Console.ForegroundColor = ConsoleColor.Green);
                Console.WriteLine("These are your stats:",
                    Console.ForegroundColor = ConsoleColor.White);

                Console.WriteLine(name + "(" + race + ")" + " the " + charClass);
                Console.WriteLine("Status: " + health + " HP, " + strength + " STR, " + agility + " AGI");
                Console.WriteLine("\n" + "Press Enter to start the game...");
                Console.ReadLine();
                Console.Clear();



                //GAMEPLAY
                Random stats = new Random();
                int randomAgi = stats.Next(1, 10);
                int randomStr = stats.Next(1, 10);

                int randomAgi1 = stats.Next(1, 10);
                int randomStr1 = stats.Next(1, 10);

                int randomAgi2 = stats.Next(1, 10);
                int randomStr2 = stats.Next(1, 10);

                int randomAgi3 = stats.Next(1, 10);
                int randomStr3 = stats.Next(1, 10);

                int randomAgi4 = stats.Next(1, 10);
                int randomStr4 = stats.Next(1, 10);

                string input = "";

                while (event1)
                {
                    Console.WriteLine("Bandits attack you out of nowhere. They seem very dangerous...",
                    Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Health: " + health + "\n");
                    Console.WriteLine("1) Fight");
                    Console.WriteLine("2) Run");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        if (strength < randomStr)
                        {
                            health -= 20;

                            Console.WriteLine("You lost the fight!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event1 = false;
                        }
                        else if (strength >= randomStr)
                        {
                            Console.WriteLine("You won the fight!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event1 = false;
                        }
                    }
                    else if (input == "2")
                    {
                        if (agility < randomAgi)
                        {
                            health -= 20;

                            Console.WriteLine("You didn't manage to run away!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event1 = false;
                        }
                        else if (agility >= randomAgi)
                        {
                            Console.WriteLine("You ran away!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event1 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                while (event2)
                {
                    Console.WriteLine("You bump in to one of the guards of the nearby village. They attack you without warning...",
                    Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Health: " + health + "\n");
                    Console.WriteLine("1) Fight");
                    Console.WriteLine("2) Run");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        if (strength < randomStr1)
                        {
                            health -= 30;

                            Console.WriteLine("You lost the fight!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event2 = false;
                        }
                        else if (strength >= randomStr1)
                        {
                            Console.WriteLine("You won the fight!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event2 = false;
                        }
                    }
                    else if (input == "2")
                    {
                        if (agility < randomAgi1)
                        {
                            health -= 30;

                            Console.WriteLine("You didn't manage to run away!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event2 = false;
                        }
                        else if (agility >= randomAgi1)
                        {
                            Console.WriteLine("You ran away!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event2 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                while (event3)
                {
                    Console.WriteLine("A Land Shark appears. It starts chasing you down to eat you...",
                    Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Health: " + health + "\n");
                    Console.WriteLine("1) Fight");
                    Console.WriteLine("2) Run");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        if (strength < randomStr2)
                        {
                            health -= 50;

                            Console.WriteLine("You lost the fight!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event3 = false;
                        }
                        else if (strength >= randomStr2)
                        {
                            Console.WriteLine("You won the fight!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event3 = false;
                        }
                    }
                    else if (input == "2")
                    {
                        if (agility < randomAgi2)
                        {
                            health -= 50;

                            Console.WriteLine("You didn't manage to run away!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event3 = false;
                        }
                        else if (agility >= randomAgi2)
                        {
                            Console.WriteLine("You ran away!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event3 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                while (event4)
                {
                    Console.WriteLine("You accidentally step on a rat. His friends are not happy. They attack...",
                    Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Health: " + health + "\n");
                    Console.WriteLine("1) Fight");
                    Console.WriteLine("2) Run");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        if (strength < randomStr3)
                        {
                            health -= 10;

                            Console.WriteLine("You lost the fight!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event4 = false;
                        }
                        else if (strength >= randomStr3)
                        {
                            Console.WriteLine("You won the fight!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event4 = false;
                        }
                    }
                    else if (input == "2")
                    {
                        if (agility < randomAgi3)
                        {
                            health -= 10;

                            Console.WriteLine("You didn't manage to run away!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event4 = false;
                        }
                        else if (agility >= randomAgi3)
                        {
                            Console.WriteLine("You ran away!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event4 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }


                while (event5)
                {
                    Console.WriteLine("You find a huge rock. It comes alive somehow and tries to smash you...",
                    Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Health: " + health + "\n");
                    Console.WriteLine("1) Fight");
                    Console.WriteLine("2) Run");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        if (strength < randomStr4)
                        {
                            health -= 30;

                            Console.WriteLine("You lost the fight!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event5 = false;
                        }
                        else if (strength >= randomStr4)
                        {
                            Console.WriteLine("You won the fight!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event5 = false;
                        }
                    }
                    else if (input == "2")
                    {
                        if (agility < randomAgi4)
                        {
                            health -= 30;

                            Console.WriteLine("You didn't manage to run away!",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event5 = false;
                        }
                        else if (agility >= randomAgi4)
                        {
                            Console.WriteLine("You ran away!",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("Press enter to continue...",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();

                            event5 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options. Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                if (health > 0)
                {
                    Console.WriteLine("YOU WON!" + "\n",
                            Console.ForegroundColor = ConsoleColor.Green);
                }
                else if (health <= 0)
                {
                    Console.WriteLine("YOU LOST!" + "\n",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                }


                while(startOver)
                {
                    Console.WriteLine("Want to play again?",
                            Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");
                    
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Press Enter to start with character creation...");
                        Console.ReadLine();
                        Console.Clear();

                        startOver = false;

                    }
                    else if (input == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for playing. Press Enter to exit and have a nice day!");

                        startOver = false;
                        heroesJourney = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number from the options.Press enter and try again...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
