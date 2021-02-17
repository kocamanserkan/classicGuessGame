using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessGamee
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)


            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("Welcomee to the Guess Game !!!");
                Console.WriteLine();
                Console.WriteLine("The lucky number is already created. ");
                Console.WriteLine("You just have to guess to lucky number between 0-10 in 3 times... Good Luck :)...");
                Random rdn = new Random();

                int correctValue = rdn.Next(0, 11);
                Console.WriteLine(correctValue);
                int i = 1;


                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Enter Your {0}. Guess: ", i);
                    var guessstr = Console.ReadLine();
                    int guess = Convert.ToInt32(guessstr);

                    if (correctValue == guess)
                    {
                        Console.WriteLine();
                        Console.WriteLine("WP!! You got it in {1}. times... The Lucky number was {0}", correctValue, i);
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine();
                        Console.Write("----To play again for P, Quit for Q-----: ");
                        var question = Console.ReadLine();
                        if (question == "Y" || question == "y")
                        {
                            break;

                        }


                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Goood Bye!!!");
                            System.Environment.Exit(0);
                        }
                    }

                    if (i == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Lostt :((");
                        Console.WriteLine("The Lucky number was {0}...", correctValue);

                        Console.WriteLine();
                        Console.WriteLine("------------------------------");
                        Console.WriteLine();
                        Console.Write("----To play again for P, Quit for Q-----: ");
                        var question = Console.ReadLine();
                        if (question == "P" || question == "p")
                        {
                            break;
                        }


                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Goood Bye!!!");
                            Console.WriteLine();

                            System.Environment.Exit(0);
                        }

                    }
                    i++;
                }



            }


        }
    }
}
