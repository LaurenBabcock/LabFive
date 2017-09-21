//Name: Lauren Babcock
//Date: September 19, 2017
//Program: Lab 5
//Purpose: Create an application that simulates two dice rolling, with the number of sides specified by the user.

using System;

namespace LabFive
{
    class Program
    {
        static void Main(string[] args)
        {

            bool run = true;
            Random rng = new Random();
            string userResponse = null;
            int min = 1;
            int max;

            //Prompt the user to see if they would like to roll two dice.
            Console.Write("Welcome to Lauren's Dice Roller! Would you like to roll the dice? (Y/N) ");
            userResponse = Console.ReadLine().ToUpper();
                     
            if (userResponse == "Y")
            {
                //If they would like to roll the dice, Prompt the user to enter the number of sides they would like (between 3 & 20)
                Console.Write("How many sides should each die have? Must be between 3-20: ");
                max = int.Parse(Console.ReadLine());

                //rollCounter will keep track of the number of rolls that the user has made
                int rollCounter = 1;

                while (run == true)
                {
                    //Generate two random rolls & output them to the console.
                    Console.WriteLine("Roll " + rollCounter + ": ");
                    Console.WriteLine(rng.Next(min, max));
                    Console.WriteLine(rng.Next(min, max));

                    //Prompt the user to roll again if they would like
                    Console.WriteLine();
                    run = Continue();
                    Console.WriteLine();
                    rollCounter++;
                }
            }
            else
            {
                //If they don't want to roll the dice, say goodbye!
                Console.WriteLine("Aw that's a shame. See you next time!");
            }
        }

        static bool Continue()
        {
            Console.Write("Would you like to roll again (Y/N)? ");
            string input = Console.ReadLine().ToUpper();
            bool doAgain;
            if (input == "Y")
            {
                doAgain = true;
            }
            else if (input == "N")
            {
                doAgain = false;
            }
            else
            {
                Console.WriteLine("That is not a valid response. Please try again.");
                doAgain = Continue();
            }

            return doAgain;
        }
    }
}
