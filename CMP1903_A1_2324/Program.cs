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
            //repeat until the user does not want to play anymore
            //ask user what game it wants to play
            //ask user if they want to see statistics
            //have error handling
            bool quit = false;
            while (quit == false) //use while loop
            {
                //ask which game
                Console.WriteLine("Which game would you like to play? Sevens Out Or ThreeOrMore? S / T");
                string userAnswer = Console.ReadLine(); //store the user's answer
                //create if statement to go to the correct game selected
                if (userAnswer == "S")
                {
                    //call the game
                    Game.SevensOut();
                    //test the game
                    Testing.testSum();
                    //ask if they want to see statistics and handle any invalid input
                    do
                    {
                        Console.WriteLine("Would you like to see the statistics for Sevens Out? Y / N");
                        string userContinue = Console.ReadLine();
                        if (userContinue == "Y")
                        {
                            //call statistics class
                            Statistics.SevensOutStatistics();
                        }
                        else if (userContinue == "N")
                        {
                            quit = true;
                            break;
                        }
                        else
                        {
                            //give error message
                            Console.WriteLine("Invalid input. Please enter Y or N.");
                            Console.ReadLine();
                        }
                    } while (true);
                    do
                    {
                        //ask user if they want to play
                        //handle errors
                        Console.WriteLine("Would you like to play again? Y / N");
                        string userContinue = Console.ReadLine(); //store user answer
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
                            //give error message
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
