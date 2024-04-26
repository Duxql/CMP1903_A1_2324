using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {

        //Test the sum method is working properly, and if it's not, say so
        public static void testSum()
        {
            //get the sum
            //clarify what test this is
            Console.WriteLine("Sevens Out Test");
            //get the sum by calling the function/method
            int testSum = Game.GetSum();
            //use debug.assert to make sure it is right and if it's not to display a message
            Debug.Assert(testSum == 7, "Dice sum has not ran properly!");
        }
        public static void testScore()
        {
            //get the score
            //clarify the test
            Console.WriteLine("Three Or More Test");
            //get the score by calling the function/method
            int testScore = Game.GetScore();
            //use debug.assert to make sure it is right and if it's not to display a message
            Debug.Assert(testScore > 19, "Score winner was not worked out properly!");
        }
    }
}
