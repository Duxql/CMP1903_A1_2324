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
		public int Value{ get; set; }
        public Die(int value)
        {
            Value = value;
        }
		
		//method
		public static int Roll() 
        {
			//Console.WriteLine("The code is still working.");
			Random rnd = new Random();
			int dieNumber = rnd.Next(1, 7);
			myDie.Value = dieNumber;
			return myDie.Value;
        }
    }
}
