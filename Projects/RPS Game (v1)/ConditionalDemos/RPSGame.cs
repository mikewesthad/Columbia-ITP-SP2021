using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConditionalDemos
{
    class RPSGame
    {
        private string RockGraphic = @"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";
        private string ScissorsGraphic = @"    _______
---'   ____)____
          ______)
        __________)
      (____)
---.__(___)";
        private string PaperGraphic = @"    _______
---'   ____)____
          ______)
          _______)
          _______)
---.__________)";
        private string ErrorGraphic = @"  ___ _ __ _ __ ___  _ __ 
/ _ \ '__| '__/ _ \| '__|
|  __/ |  | | | (_) | |   
\___|_|  |_|  \___/|_|";

        public void Play()
        {
            WriteLine("~~~ RPS Game ~~~");

            WriteLine("Would you like to play? (yes/no)");
            string playResponse = ReadLine().Trim().ToLower();
            //string playResponseLower = playResponse.ToLower();
            //string playResponseTrimmed = playResponseLower.Trim();


            if (playResponse == "yes")
            {
                WriteLine("Great. Let's play.");
                WriteLine("Rock, paper or scissors?");
                string playerMove = ReadLine().Trim().ToLower();

                WriteLine("");
                if (playerMove == "rock")
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("You played rock...");
                    WriteLine(RockGraphic);
                    WriteLine("");

                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The AI played paper!");
                    WriteLine(PaperGraphic);
                    
                    WriteLine("\nYou lose.");
                    ForegroundColor = ConsoleColor.White;
                }
                else if (playerMove == "paper")
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("You played paper...");
                    WriteLine(PaperGraphic);
                    WriteLine("");

                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The AI played scissors!");
                    WriteLine(ScissorsGraphic);

                    WriteLine("\nYou lose.");
                    ForegroundColor = ConsoleColor.White;
                }
                else if (playerMove == "scissors")
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("You played scissors...");
                    WriteLine(ScissorsGraphic);
                    WriteLine("");

                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("The AI played rock!");
                    WriteLine(RockGraphic);

                    WriteLine("\nYou lose.");
                    ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine($"You played: {playerMove}...");
                    WriteLine(ErrorGraphic);
                    WriteLine("Error, error. The AI broke.");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nYou win!");
                }

                WriteLine("\nWould you like to play again? (yes/no)");
                string playAgainResponse = ReadLine().ToLower().Trim();
                if (playAgainResponse == "yes")
                {
                    Clear();

                    // Recursion!
                    Play();
                }
                else
                {
                    WriteLine("It was fun playing, see you again soon.");
                }
            }
            else
            {
                WriteLine("Aw shucks, maybe next time.");
            }
        }
    }
}
