using System;

namespace loginRegisterApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = "";
            string password = "";
            bool application = true;

            string[] emails = new string[]
            {
                "admin@admindomain.com",
                "bob.bobsky@mail.com"
            };

            string[] passwords = new string[]
            {
                "Ad#mi8$s@!",
                "Bobsky22$$"
            };

            while(application)
            {
                Console.WriteLine("Register, or log in if you already have an account:",
                    Console.ForegroundColor = ConsoleColor.White);
                Console.WriteLine("1) Register");
                Console.WriteLine("2) Log in");
                string input = Console.ReadLine();
                Console.Clear();

                bool register = false;
                bool login = false;
                bool mail = true;
                bool pass = true;

                switch(input)
                {
                    case "1":
                        register = true;
                        break;
                    case "2":
                        login = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input, press Enter to try again.",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

                while(register)
                {
                    while(mail)
                    {
                        Console.Clear();
                        Console.Write("Enter your email: ",
                            Console.ForegroundColor = ConsoleColor.White);
                        email = Console.ReadLine();

                        if(!email.Contains('@') || !email.Contains('.'))
                        {
                            Console.WriteLine("Invalid email, press Enter to try again.",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else if(char.IsSymbol(email[0]) || char.IsSymbol(email[email.Length - 1]) || char.IsDigit(email[0]) || char.IsDigit(email[email.Length - 1]))
                        {
                            Console.WriteLine("Invalid email, can't start or end with a special character or number.",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("Press Enter to try again.");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else if(email.Length > 30)
                        {
                            Console.WriteLine("Email too long, press Enter to try again.",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {
                            Array.Resize(ref emails, emails.Length + 1);
                            emails[emails.Length - 1] = email;

                            break;
                        }
                    }


                    while(pass)
                    {
                        Console.Clear();
                        Console.Write("Enter your password: ",
                            Console.ForegroundColor = ConsoleColor.White);
                        password = Console.ReadLine();

                        int digit = 0;
                        int upper = 0;
                        int lower = 0;
                        int symbol = 0;

                        foreach(char ch in password)
                        {
                            if(char.IsDigit(ch)) digit++;
                            if(char.IsUpper(ch)) upper++;
                            if(char.IsLower(ch)) lower++;
                            if(char.IsSymbol(ch)) symbol++;
                        }

                        if(password.Length < 10)
                        {
                            Console.WriteLine("\n" + "Password is too short. (must be at least 10 characters)",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if(digit > 0 && upper > 0 && lower > 0 && symbol > 1)
                        {
                            Array.Resize(ref passwords, passwords.Length + 1);
                            passwords[passwords.Length - 1] = password;

                            Console.Clear();
                            Console.WriteLine("Registration successful! Press Enter to Log in.",
                                Console.ForegroundColor = ConsoleColor.Green);
                            Console.ReadLine();
                            Console.Clear();
                            register = false;
                            break; 
                        }
                        else
                        {
                            Console.WriteLine("\n" + "The password must be a combination of small and big letters,",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.WriteLine("numbers and at least two special characters. Press Enter to try again.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }

                bool admin = false;
                bool user = true;
                int loginAttempts = 0;

                while(login)
                {
                    string logiMail = "";
                    string logiPass = "";
                    int indexMail = 0;
                    int indexPass = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        if((indexMail == -1 || indexPass == -1))
                        {
                            Console.WriteLine("Invalid email or password, press Enter to try again.",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();
                        }

                        Console.Clear();
                        Console.Write("Enter your email: ",
                            Console.ForegroundColor = ConsoleColor.White);
                        logiMail = Console.ReadLine();
                        indexMail = Array.IndexOf(emails, logiMail);

                        Console.Write("Enter your password: ");
                        logiPass = Console.ReadLine();
                        indexPass = Array.IndexOf(passwords, logiPass);
                        Console.Clear();


                        if(logiMail == "admin@admindomain.com" && logiPass == "Ad#mi8$s@!")
                        {
                            admin = true;
                            user = false;
                            break;
                        }
                        else if(indexMail == -1 || indexPass == -1)
                        {
                            loginAttempts++;
                        }
                        else if(logiMail.Equals(emails[indexMail]) && logiPass.Equals(passwords[indexPass]))
                        {
                            user = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid email or password, press Enter to try again.",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();
                            loginAttempts++;                      
                        }
                    }

                    if(loginAttempts > 2)
                    {
                        Console.WriteLine("You tried too many times! Press Enter to exit.",
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        application = false;
                        break;
                    }
                    else
                    {
                        while(user)
                        {
                            Console.WriteLine("Welcome " + logiMail + "\n",
                               Console.ForegroundColor = ConsoleColor.Green);
                            Console.WriteLine("1) Show users list",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.WriteLine("2) Log out");
                            Console.WriteLine("3) Exit");
                            input = Console.ReadLine();
                            Console.Clear();

                            if(input == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("List of all users in the system:" + "\n");

                                foreach(string item in emails)
                                {
                                    Console.WriteLine(item, Console.ForegroundColor = ConsoleColor.Yellow);
                                }

                                Console.WriteLine("\n" + "Press Enter to go back.",
                                    Console.ForegroundColor = ConsoleColor.White);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(input == "2")
                            {
                                break;
                            }
                            else if(input == "3")
                            {
                                login = false;
                                application = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, press Enter to go back",
                                    Console.ForegroundColor = ConsoleColor.DarkRed);
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }

                    while(admin)
                    {
                        Console.WriteLine("Welcome admin" + "\n",
                            Console.ForegroundColor = ConsoleColor.Green);
                        Console.WriteLine("1) List of all users",
                            Console.ForegroundColor = ConsoleColor.White);
                        Console.WriteLine("2) Delete user");
                        Console.WriteLine("3) Log out");
                        Console.WriteLine("4) Exit");
                        input = Console.ReadLine();
                        Console.Clear();

                        if(input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("List of all users in the system:" + "\n");

                            foreach(string item in emails)
                            {
                                Console.WriteLine(item, Console.ForegroundColor = ConsoleColor.Yellow);
                            }

                            Console.WriteLine("\n" + "Press Enter to go back.",
                                Console.ForegroundColor = ConsoleColor.White);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (input == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Enter an email of a user you want to delete");
                            Console.Write("Email: ");

                            logiMail = Console.ReadLine();
                            int index = Array.IndexOf(emails, logiMail);

                            if(index == -1)
                            {
                                Console.WriteLine("\n" + "The user is not in the system.",
                                    Console.ForegroundColor = ConsoleColor.DarkRed);
                                Console.WriteLine("Press Enter to go back.",
                                    Console.ForegroundColor = ConsoleColor.White);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(index == 0)
                            {
                                Console.WriteLine("\n" + "You can't delete this email address!",
                                    Console.ForegroundColor = ConsoleColor.DarkRed);
                                Console.WriteLine("Press Enter to go back.",
                                    Console.ForegroundColor = ConsoleColor.White);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(logiMail.Equals(emails[index]))
                            {
                                emails[emails.Length - 1] = emails[index];

                                Array.Resize(ref emails, emails.Length - 1);

                                Console.WriteLine("\n" + "User was successfully removed.",
                                    Console.ForegroundColor = ConsoleColor.Green);
                                Console.WriteLine("Press Enter to go back.",
                                    Console.ForegroundColor = ConsoleColor.White);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("\n" + "The user is not in the system.",
                                    Console.ForegroundColor = ConsoleColor.DarkRed);
                                Console.WriteLine("Press Enter to go back.",
                                    Console.ForegroundColor = ConsoleColor.White);
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else if(input == "3")
                        {
                            break;
                        }
                        else if(input == "4")
                        {
                            login = false;
                            application = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, press Enter to go back",
                                Console.ForegroundColor = ConsoleColor.DarkRed);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
