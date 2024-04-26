using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
        public static void SevensOutStatistics()
        {
            //get the sum from the correct game
            //get the number of plays
            //put all of them in a list for easier storage/not overall for multiple values
            int sum = Game.GetSum();
            //create averages for each variable obtained
            float averageHighscore = 0;
            int numberOfPlays = Game.GetNumberOfPlays();
            float averageNumberOfPlays = 0;
            List<int> highscores = new List<int>();
            highscores.Add(sum);
            List<int> numberOfPlaysList = new List<int>();
            numberOfPlaysList.Add(numberOfPlays);
            //display all the sums/highscores and all of number of plays
            Console.WriteLine("All the current highscores (number of plays it took) are:");
            for (int i = 0; i < highscores.Count; i++)
            {
                Console.WriteLine(" " + highscores[i] + " (" + numberOfPlaysList[i] + ")");
                //add them all up to work out averages
                averageHighscore = averageHighscore + highscores[i];
                averageNumberOfPlays = averageNumberOfPlays + numberOfPlaysList[i];
            }
            Console.ReadLine();
            //finish working out averages
            averageHighscore = averageHighscore / highscores.Count;
            averageNumberOfPlays = averageNumberOfPlays / numberOfPlaysList.Count;
            //display the average highscore and average number of plays
            Console.WriteLine("Average highscore is " + averageHighscore);
            Console.WriteLine("Average number of plays is " + averageNumberOfPlays);
            Console.ReadLine();
        }
        public static void ThreeOrMoreStatistics()
        {
            //get the amount of plays to win
            //put in list for easier access/not overlap
            int playsForWin = Game.GetPlaysForWin();
            float averagePlaysForWin = 0;
            List<int> playsForWins = new List<int>();
            playsForWins.Add(playsForWin);
            //display amount of plays/turns to win
            Console.WriteLine("All the current turns that it took for the player to win are:");
            for (int i = 0; i < playsForWins.Count; i++)
            {
                Console.Write(playsForWins[i] + " ");
                //add to work average
                averagePlaysForWin = averagePlaysForWin + playsForWins[i];
            }
            Console.ReadLine();
            //finish working out average
            averagePlaysForWin = averagePlaysForWin / playsForWins.Count;
            //display average for amount of turns to win
            Console.WriteLine("Average turns it took for a player to win is " + averagePlaysForWin);
            Console.ReadLine();
        }
    }
}
