using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (quit == false)
            {
                Console.WriteLine("Which game would you like to play? Sevens Out Or ThreeOrMore? S / T");
                string userAnswer = Console.ReadLine();
                if (userAnswer == "S")
                {
                    Game.SevensOut();
                    Testing.testSum();
                    do
                    {
                        Console.WriteLine("Would you like to see the statistics for Sevens Out? Y / N");
                        string userContinue = Console.ReadLine();
                        if (userContinue == "Y")
                        {
                            Statistics.SevensOutStatistics();
                        }
                        else if (userContinue == "N")
                        {
                            quit = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N.");
                            Console.ReadLine();
                        }
                    } while (true);
                    do
                    {
                        Console.WriteLine("Would you like to play again? Y / N");
                        string userContinue = Console.ReadLine();
                        if (userContinue == "Y")
                        {
                            break;
                        }
                        else if (userContinue == "N")
                        {
                            quit = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N.");
                            Console.ReadLine();
                        }
                    } while (true);
                }

                else if (userAnswer == "T")
                {
                    Game.ThreeOrMore();
                    Testing.testScore();
                    do
                    {
                        Console.WriteLine("Would you like to see the statistics for Three Or More? Y / N");
                        string userContinue = Console.ReadLine();
                        if (userContinue == "Y")
                        {
                            Statistics.ThreeOrMoreStatistics();
                        }
                        else if (userContinue == "N")
                        {
                            quit = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N.");
                            Console.ReadLine();
                        }
                    } while (true);
                    do
                    {
                        Console.WriteLine("Would you like to play again? Y / N");
                        string userContinue = Console.ReadLine();
                        if (userContinue == "Y")
                        {
                            break;
                        }
                        else if (userContinue == "N")
                        {
                            quit = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter Y or N.");
                            Console.ReadLine();
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine("Please type either S or T.");
                }

                Console.ReadLine();
            }
        }
    }
}
