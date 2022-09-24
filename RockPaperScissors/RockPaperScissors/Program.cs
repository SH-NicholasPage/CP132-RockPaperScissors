/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/
#pragma warning disable CS8600
#pragma warning disable CS8602 
using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            //--------SAMPLE CODE----------------------------------------------
            Console.Write("Input a greeting: ");
            String greeting = Console.ReadLine();

            //Remember to use double vertical bars (||) for ors and double ampersand (&&) for ands
            if (greeting.Equals("hello") == true || greeting.Equals("hi") == true)
            {
                Console.WriteLine("Thank you for your greeting!");
            }
            else
            {
                Console.WriteLine("That wasn't a greeting I recognized.");
            }
            //----------------------------------------------------------------
        }
    }
}