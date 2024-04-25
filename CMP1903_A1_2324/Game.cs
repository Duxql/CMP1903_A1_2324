﻿using System;
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
        public static void SevensOut()
        {
            //roll each dice
            //display the value of each dice
            bool gameOver = false;
            int sum = 0;
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
                    Console.WriteLine("The current sum of all your dices: " + sum);
                    Console.WriteLine("Game Over! You got a sum of 7 in the last 2 dices, unlucky!");
                    gameOver = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The current sum of all your dices: " + sum);
                    Console.ReadLine();
                }

            }
        }

        public static void ThreeOrMore()
        {
            int userOnePoints = 0;
            int userTwoPoints = 0;
            bool gameOver = false;
            Console.WriteLine("1 Player or 2 Players? 1 | 2");
            int amountOfPlayers = int.Parse(Console.ReadLine());
            while (gameOver == false)
            {
                if (amountOfPlayers == 1)
                {
                    userOnePoints += ThreeOrMorePlayer(userOnePoints, 1);
                    if (userOnePoints >= 20)
                    {
                        Console.WriteLine("Player 1 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        Console.ReadLine();
                        gameOver = true;
                        break;
                    }
                    userTwoPoints += ThreeOrMorePlayer(userTwoPoints, 0);
                    if (userTwoPoints >= 20)
                    {
                        Console.WriteLine("Player 2 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        Console.ReadLine();
                        gameOver = true;
                        break;
                    }
                }
                else if (amountOfPlayers == 2)
                {
                    userOnePoints += ThreeOrMorePlayer(userOnePoints, 1);
                    if (userOnePoints >= 20)
                    {
                        Console.WriteLine("Player 1 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        Console.ReadLine();
                        gameOver = true;
                        break;
                    }
                    userTwoPoints += ThreeOrMorePlayer(userTwoPoints, 1);   
                    if (userTwoPoints >= 20)
                    {
                        Console.WriteLine("Player 2 has won! The amount of points players finished with are: Player 1 - " + userOnePoints + "; Player 2 - " + userTwoPoints);
                        Console.ReadLine();
                        gameOver = true;
                        break;
                    }
                }
            }
            
        }

        public static int ThreeOrMorePlayer(int userPoints, int playerOrNot)
        {
            Die dieOne = new Die(0);
            dieOne.Value = Die.Roll();
            Die dieTwo = new Die(0);
            dieTwo.Value = Die.Roll();
            Die dieThree = new Die(0);
            dieThree.Value = Die.Roll();
            Die dieFour = new Die(0);
            dieFour.Value = Die.Roll();
            Die dieFive = new Die(0);
            dieFive.Value = Die.Roll();

            if (playerOrNot == 1)
            {
                //user code
            }
            else if (playerOrNot == 0)
            {
                //computer code
            }

            return userPoints;
        }

    }
}
