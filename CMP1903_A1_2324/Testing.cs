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

        //Test the sum method is working properly, and if it's not, say so
        public static void testSum()
        {
            //Sum the dices
            Console.WriteLine("Sevens Out Test");
            int testSum = Game.SevensOut();
            //use debug.assert to make sure it is right and if it's not to display a message
            Debug.Assert(testSum == 7, "Dice sum has not ran properly!");
        }
        public static void testScore()
        {
            //Sum the dices
            Console.WriteLine("Three Or More Test");
            int testScore = Game.ThreeOrMore();
            //use debug.assert to make sure it is right and if it's not to display a message
            Debug.Assert(testScore > 19, "Dice sum has not ran properly!");
        }
    }
}
