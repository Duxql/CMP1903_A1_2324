using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
		//Create the die object property with a value so it can be assigned a value
		public int Value{get; set;}
        public Die(int value)
        {
            Value = value;
        }
		
		//method
		//create a method that generates a random number 1-6 and it returns that value to anything that calls this method
		private static Random rnd = new Random();
		public static int Roll()
		{
			//randomise the number
			//return the number
			return rnd.Next(1, 7);
		}
    }
}
