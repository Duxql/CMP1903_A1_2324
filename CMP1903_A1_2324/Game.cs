using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        //create a method that rolls 3 dices and sums them up while displaying the value of each dice and the sum of the dice


        private static int sum;
        private static int numberOfPlays;
        private static int scoreWinner;
        private static int playsForWin;

        public static void SevensOut()
        {
            //roll each dice
            //display the value of each dice
            bool gameOver = false;
            while (gameOver == false)
            {

                Die dieOne = new Die(0);
                dieOne.Value = Die.Roll();
                Console.WriteLine("The first dice roll is: " + dieOne.Value);
                Die dieTwo = new Die(0);
                dieTwo.Value = Die.Roll();
                Console.WriteLine("The second dice roll is: " + dieTwo.Value);
                Console.ReadLine();

                //add the dices up and assign that value to a variable
                //display the value
                //if they are the same, double it
                if (dieOne.Value == dieTwo.Value)
                {
                    sum += (dieOne.Value + dieTwo.Value) * 2;
                }
                else
                {
                    sum += dieOne.Value + dieTwo.Value;
                }

                //if the sum is 7, end the game
                if (dieOne.Value + dieTwo.Value == 7)
                {
                    numberOfPlays++;
                    Console.WriteLine("The current sum of all your dices: " + sum);
                    Console.WriteLine("Game Over! You got a sum of 7 in the last 2 dices, unlucky!");
                    gameOver = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The current sum of all your dices: " + sum);
                    numberOfPlays++;
                    Console.ReadLine();
                }
            }
        }

        public static int GetSum()
        {
            return sum;
        }
        public static int GetNumberOfPlays()
        {
            return numberOfPlays;
        }

        public static void ThreeOrMore()
        {
            int counterForPlaysPlayerOne = 0;
            int counterForPlaysPlayerTwo = 0;
            int userOnePoints = 0;
            int userTwoPoints = 0;
            bool gameOver = false;
            Console.WriteLine("1 Player or 2 Players? 1 | 2");
            int amountOfPlayers = int.Parse(Console.ReadLine());
            while (gameOver == false)
            {
                if (amountOfPlayers == 1)
                {
                    Console.WriteLine("Player 1 Turn");
                    counterForPlaysPlayerOne++;
                    userOnePoints = ThreeOrMorePlayer(userOnePoints, 1);
                    if (userOnePoints >= 20)
                    {
                        Console.WriteLine("Player 1 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        scoreWinner = userOnePoints;
                        playsForWin = counterForPlaysPlayerOne;
                        Console.ReadLine();
                        break;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Computer Turn");
                    counterForPlaysPlayerTwo++;
                    userTwoPoints = ThreeOrMorePlayer(userTwoPoints, 0);
                    if (userTwoPoints >= 20)
                    {
                        Console.WriteLine("Computer has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Computer - " + userTwoPoints);
                        scoreWinner = userTwoPoints;
                        playsForWin = counterForPlaysPlayerTwo;
                        Console.ReadLine();
                        break;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Current points of player and computer: Player - " + userOnePoints + " || Computer - " + userTwoPoints);
                    Console.ReadLine();
                }
                else if (amountOfPlayers == 2)
                {
                    Console.WriteLine("Player 1 Turn");
                    counterForPlaysPlayerOne++;
                    userOnePoints = ThreeOrMorePlayer(userOnePoints, 1);
                    if (userOnePoints >= 20)
                    {
                        Console.WriteLine("Player 1 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        scoreWinner = userOnePoints;
                        playsForWin = counterForPlaysPlayerOne;
                        Console.ReadLine();
                        break;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Player 2 Turn");
                    counterForPlaysPlayerTwo++;
                    userTwoPoints = ThreeOrMorePlayer(userTwoPoints, 1);
                    if (userTwoPoints >= 20)
                    {
                        Console.WriteLine("Player 2 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        scoreWinner = userTwoPoints;
                        playsForWin = counterForPlaysPlayerTwo;
                        Console.ReadLine();
                        break;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Current points of both players: Player 1 - " + userOnePoints + " || Player 2 - " + userTwoPoints);
                    Console.ReadLine();
                }
            }
        }
        public static int GetScore()
        {
            return scoreWinner;
        }
        public static int GetPlaysForWin()
        {
            return playsForWin;
        }

        public static int ThreeOrMorePlayer(int userPoints, int playerOrNot)
        {
            

            if (playerOrNot == 1)
            {
                int initialUserPoints = userPoints;
                Die[] dices = new Die[5];
                for (int i = 0; i < 5; i++)
                {
                    dices[i] = new Die(0);
                    //Console.WriteLine("test"); see if it is being initialised
                }
                //Console.ReadLine(); see if it is being initialised
                for (int i = 0; i < 5; i++)
                {
                    dices[i].Value = Die.Roll();
                    //Console.WriteLine(dices[i].Value); check for correct values
                }
                //Console.ReadLine();
                int counter = 0;
                int temporaryI = 0;
                int temporaryJ = 0;
                bool turn = true;
                while (turn == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (dices[i].Value == dices[j].Value)
                            {
                                counter += 1;
                                //Console.WriteLine(counter);
                                if (counter == 2)
                                {
                                    temporaryJ = j;
                                }
                            }
                        }
                        if (counter == 5)
                        {
                            userPoints += 12;
                            Console.WriteLine("You won! You got 12 points! Your current points are: " + userPoints + ". Here are your dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 4)
                        {
                            userPoints += 6;
                            Console.WriteLine("You won! You got 6 points! Your current points are: " + userPoints + ". Here are your dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 3)
                        {
                            userPoints += 3;
                            Console.WriteLine("You won! You got 3 points! Your current points are: " + userPoints + ". Here are your dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 2)
                        {
                            if (i != temporaryJ)
                            {
                                temporaryI = i;
                            }
                            
                        }
                        counter = 0;
                    }
                    if (initialUserPoints != userPoints)
                    {
                        break;
                    }
                    
                    Console.WriteLine("Here are your dice rolls: ");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(dices[i].Value + " ");
                    }
                    Console.WriteLine("Would you like to reroll all or reroll anything that isn't " + dices[temporaryI].Value + "? Y (For All) / N (For Not All)");
                    string userRerollAnswer = Console.ReadLine();
                    if (userRerollAnswer == "Y")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            dices[i].Value = Die.Roll();
                        }
                    }
                    if (userRerollAnswer == "N")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (i != temporaryI && i != temporaryJ)
                            {
                                dices[i].Value = Die.Roll();
                            }
                        }
                    }
                }
            }
            else if (playerOrNot == 0)
            {
                int initialUserPoints = userPoints;
                Die[] dices = new Die[5];
                for (int i = 0; i < 5; i++)
                {
                    dices[i] = new Die(0);
                    //Console.WriteLine("test"); see if it is being initialised
                }
                //Console.ReadLine(); see if it is being initialised
                for (int i = 0; i < 5; i++)
                {
                    dices[i].Value = Die.Roll();
                    //Console.WriteLine(dices[i].Value); check for correct values
                }
                //Console.ReadLine();
                int counter = 0;
                int temporaryI = 0;
                int temporaryJ = 0;
                bool turn = true;
                while (turn == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (dices[i].Value == dices[j].Value)
                            {
                                counter += 1;
                                temporaryJ = j;
                            }
                        }
                        if (counter == 5)
                        {
                            userPoints += 12;
                            Console.WriteLine("Computer won! Computer got 12 points! Computer's current points are: " + userPoints + ". Here are their dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 4)
                        {
                            userPoints += 6;
                            Console.WriteLine("Computer won! Computer got 6 points! Computer's current points are: " + userPoints + ". Here are their dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 3)
                        {
                            userPoints += 3;
                            Console.WriteLine("Computer won! Computer got 3 points! Computer's current points are: " + userPoints + ". Here are their dice rolls: ");
                            for (int z = 0; z < 5; z++)
                            {
                                Console.Write(dices[z].Value + " ");
                            }
                            Console.ReadLine();
                            break;
                        }
                        if (counter == 2)
                        {
                            temporaryI = i;
                        }
                        counter = 0;
                    }
                    if (initialUserPoints != userPoints)
                    {
                        break;
                    }
                    Console.WriteLine("Here are the Computer dice rolls: ");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(dices[i].Value + " ");
                    }
                    Console.ReadLine();
                    Random rnd = new Random();
                    int randomDecision = rnd.Next(1, 11);

                    if (randomDecision == 1)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            dices[i].Value = Die.Roll();
                        }
                    }
                    if (randomDecision != 1)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (i != temporaryI && i != temporaryJ)
                            {
                                dices[i].Value = Die.Roll();
                            }
                        }
                    }
                }
            }

            return userPoints;
        }

    }
}
