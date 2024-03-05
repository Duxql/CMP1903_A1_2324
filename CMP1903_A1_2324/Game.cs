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
		public static int DiceTotal() 
        {
            //Console.WriteLine("I will attempt to make a dice and roll it");
			//create 3 dices
			//roll each dice
			//display the value of each dice
            Die myDieOne = new Die(0);
			myDieOne.Value = Die.Roll();
			Console.WriteLine("The first dice roll is: " + myDieOne.Value);
			Die myDieTwo = new Die(0);
			myDieTwo.Value = Die.Roll();
			Console.WriteLine("The second dice roll is: " + myDieTwo.Value);
			Die myDieThree = new Die(0);
			myDieThree.Value = Die.Roll();
			Console.WriteLine("The third dice roll is: " + myDieThree.Value);
			
			//add the dices up and assign that value to a variable
			//display the value
          	int sum = 0;
            sum = myDieOne.Value + myDieTwo.Value + myDieThree.Value;
			
			Console.WriteLine("The sum of the dices rolled is: " + sum);
			return sum;
        }

    }
}
