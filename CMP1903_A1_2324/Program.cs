﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
			 
			 //Roll the dices and sum them up
			 Game.SevensOut();
			 
			 //Test that it's correctly rolling dices
			 Testing.testDie();
			 
			 //Test that it's currently summing up the dices
			 //Testing.testSum();

            Console.ReadLine();
        }
    }
}
