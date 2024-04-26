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
            int sum = Game.GetSum();
            float averageHighscore = 0;
            int numberOfPlays = Game.GetNumberOfPlays();
            float averageNumberOfPlays = 0;
            List<int> highscores = new List<int>();
            highscores.Add(sum);
            List<int> numberOfPlaysList = new List<int>();
            numberOfPlaysList.Add(numberOfPlays);
            Console.WriteLine("All the current highscores (number of plays it took) are:");
            for (int i = 0; i < highscores.Count; i++)
            {
                Console.WriteLine(" " + highscores[i] + " (" + numberOfPlaysList[i] + ")");
                averageHighscore = averageHighscore + highscores[i];
                averageNumberOfPlays = averageNumberOfPlays + numberOfPlaysList[i];
            }
            Console.ReadLine();
            averageHighscore = averageHighscore / highscores.Count;
            averageNumberOfPlays = averageNumberOfPlays / numberOfPlaysList.Count;
            Console.WriteLine("Average highscore is " + averageHighscore);
            Console.WriteLine("Average number of plays is " + averageNumberOfPlays);
            Console.ReadLine();
        }
        public static void ThreeOrMoreStatistics()
        {
            int playsForWin = Game.GetPlaysForWin();
            float averagePlaysForWin = 0;
            List<int> playsForWins = new List<int>();
            playsForWins.Add(playsForWin);
            Console.WriteLine("All the current turns that it took for the player to win are:");
            for (int i = 0; i < playsForWins.Count; i++)
            {
                Console.Write(playsForWins[i] + " ");
                averagePlaysForWin = averagePlaysForWin + playsForWins[i];
            }
            Console.ReadLine();
            averagePlaysForWin = averagePlaysForWin / playsForWins.Count;
            Console.WriteLine("Average turns it took for a player to win is " + averagePlaysForWin);
            Console.ReadLine();
        }
    }
}
