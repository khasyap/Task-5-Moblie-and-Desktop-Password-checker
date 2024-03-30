using System.Runtime.CompilerServices;
using System.Threading;

namespace Task5
{
    internal class program
    {
        
        static void Main(string[] args)
        {
            int a, b, c, d;
            string e, f,k;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mechanism for Mobile and Desktop password.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to KK Solutions");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose your device?");
            Console.WriteLine("1. Moblie\n2. Desktop");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Enter your password (numbers (4/6)): ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter password to login: ");
                c = Convert.ToInt32(Console.ReadLine());
                if (b == c)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Welcome to moblie lock is unlocked");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Please enter correct password");
                }
                if (b != c)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Enter correct passwords.");
                    Console.Write("Please enter your password:");
                    d = Convert.ToInt32(Console.ReadLine());
                    if (d == b)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Welcome to moblie lock is unlocked");
                    }
                    else
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            int g;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Please enter your password:");
                            g = Convert.ToInt32(Console.ReadLine());
                            if (g == b)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("Welcome to moblie lock is unlocked");
                                break;
                            }
                        }
                        int countdown = 30;
                        for (int x = countdown; x > 0; x--)
                        {
                            Console.WriteLine("Time remaining:" + x + " seconds");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        if (b != c)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Enter correct passwords.");
                            Console.Write("Please enter your password:");
                            d = Convert.ToInt32(Console.ReadLine());
                            if (d == b)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Welcome to moblie lock is unlocked");
                            }
                            else
                            {
                                for (int i = 1; i < 5; i++)
                                {
                                    int g;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Please enter your password:");
                                    g = Convert.ToInt32(Console.ReadLine());
                                    if (g == b)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine("Welcome to moblie lock is unlocked");
                                        break;
                                    }
                                }

                            }
                        }
                    }

                }
            }
            if (a == 2)
            {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Enter your password : ");
                            e = Console.ReadLine();
                            Console.Write("Enter password to login : ");
                            f = Console.ReadLine();
                            if (e == f)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Welcome to Desktop lock is unlocked");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Please enter correct password");
                            }
                            if (e != f)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("Enter correct passwords.");
                                Console.Write("Please enter your password:");
                                 k=Console.ReadLine();
                                if (k == e)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Welcome to moblie lock is unlocked");
                                }
                                else
                                {
                                    for (int j = 1; j < 5; j++)
                                    {
                                        string l;
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.Write("Please enter your password:");
                                        l = Console.ReadLine();
                                        if (l == e)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("Welcome to moblie lock is unlocked");
                                            break;
                                        }
                                    }
                                    int countdow = 30;
                                    for (int y = countdow; y > 0; y--)
                                    {
                                        Console.WriteLine("Time remaining:" + y + " seconds");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    if (e != f)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine("Enter correct passwords.");
                                        Console.Write("Please enter your password:");
                                        k = Console.ReadLine();
                                        if (k == e)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("Welcome to moblie lock is unlocked");
                                        }
                                        else
                                        {
                                            for (int j = 1; j < 5; j++)
                                            {
                                                string l;
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Please enter your password:");
                                                l =Console.ReadLine();
                                                if (l== e)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                                    Console.WriteLine("Welcome to moblie lock is unlocked");
                                                    break;
                                                }
                                            }

                                        }
                                    }

                                }
                            }
                
            }
        }
    }
}






