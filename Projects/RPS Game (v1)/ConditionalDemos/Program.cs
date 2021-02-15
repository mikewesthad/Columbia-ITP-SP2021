using System;
using static System.Console;

namespace ConditionalDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "~~~ Conditional Demos ~~~";

            // Trivia Conditional Example:
            //WriteLine("What is the national animal of Scotland: unicorn or dragon?");
            //string playerResponse = ReadLine();
            //if (playerResponse == "unicorn")
            //{
            //    WriteLine("Correct!");
            //    WriteLine("It originates from Celtic mythology.");
            //}
            //else
            //{
            //    WriteLine("Wrong!");
            //    WriteLine("But that would be cool though...");
            //}

            // Temp Clothing Conditional Example:
            //WriteLine("What is the current temp in F?");
            //string tempResponse = ReadLine();
            //int temp = Convert.ToInt32(tempResponse);
            ////WriteLine($"Is temp 0? {temp == 0}"); // Equality
            ////WriteLine($"Is temp anything but 0? {temp != 0}"); // Inequality
            ////WriteLine($"Is temp greater than 0? {temp > 0}");
            ////WriteLine($"Is temp greater than or equal to 0? {temp >= 0}");
            ////WriteLine($"Is temp less than 0? {temp < 0}");
            ////WriteLine($"Is temp less than or equal to 0? {temp <= 0}");
            //if (temp <= 0)
            //{
            //    WriteLine("Don't go outside - frostbite warning!");
            //}
            //else if (temp <= 32)
            //{
            //    // 1 - 32 degrees F
            //    WriteLine("Bring a heavy coat if you go outside.");
            //}
            //else if(temp <= 65)
            //{
            //    // 33 - 65 degrees F
            //    WriteLine("Wear a sweater if you go outside.");
            //}
            //else if(temp <= 100)
            //{
            //    // 66 - 100 degrees F
            //    WriteLine("Bring a hat, sunscreen and water.");
            //}
            //else
            //{
            //    // 101+ degrees F
            //    WriteLine("Don't go outside without a personal AC.");
            //}

            // RPS Game Starts
            RPSGame myRPSGame = new RPSGame();
            myRPSGame.Play();
            
            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
