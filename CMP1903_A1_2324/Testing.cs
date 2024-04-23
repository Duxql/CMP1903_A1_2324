using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
		//Test the roll method is working properly, and if it's not, say so
		public static void testDie() 
        {
            //Roll the dice
          	int testRoll = Die.Roll();
            //use debug.assert to make sure it is right and if it's not to display a message
            System.Diagnostics.Debug.Assert(testRoll > 0 && testRoll < 7, "Roll has not ran properly!");
		}
		
		//Test the sum method is working properly, and if it's not, say so
		//public static void testSum() 
  //      {
  //          //Sum the dices
  //          Console.WriteLine("Game Test");
  //          int testSum = Game.DiceTotal();
  //          //use debug.assert to make sure it is right and if it's not to display a message
  //          System.Diagnostics.Debug.Assert(testSum > 2 && testSum < 19, "Dice sum has not ran properly!");
		//}
    }
}
