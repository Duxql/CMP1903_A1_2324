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
		public static int DiceTotal() 
        {
            Console.WriteLine("I will attempt to make a dice and roll it");
            Die myDieOne = new Die(0);
			myDieOne.Value = Die.Roll();
			Die myDieTwo = new Die(0);
			myDieTwo.Value = Die.Roll();
			Die myDieThree = new Die(0);
			myDieThree.Value = Die.Roll();
          	int sum = 0;
            sum = myDieOne.Value + myDieTwo.Value + myDieThree.Value;
    
            return sum;
        }

    }
}
