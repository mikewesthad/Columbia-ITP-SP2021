using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MazeI
{
    class Game
    {
        private World MyWorld;
        private Player Player;

        public void Start()
        {
            Title = "The Labyrinth";
            CursorVisible = false;

            // Question from class: full screen!
            //WindowWidth = LargestWindowWidth;
            //WindowHeight = LargestWindowHeight;

            //string[,] grid = {
            //   {"=", "=", "=", "=", "=", "=", "=", "=", "=", "=" },
            //   {"=", " ", " ", " ", " ", " ", " ", " ", " ", "=" },
            //   {"=", " ", "=", "=", " ", "=", " ", " ", " ", "=" },
            //   {"=", " ", "=", " ", " ", "=", " ", " ", " ", "=" },
            //   {"=", " ", "=", " ", " ", "=", " ", " ", " ", "=" },
            //   {"=", " ", "=", " ", " ", "=", " ", " ", " ", "=" },
            //   {"=", " ", "=", " ", " ", " ", " ", " ", " ", "=" },
            //   {"=", "=", "=", "=", "=", "=", "=", "=", "X", "=" }
            //};

            // https://theasciicode.com.ar/
            string[,] grid = {
               {"█", "█", "█", "█", "█", "█", "█", "█", "█", "█" },
               {"█", " ", " ", " ", " ", " ", " ", " ", " ", "█" },
               {"█", "█", "█", "█", "█", "█", " ", "█", " ", "█" },
               {"█", " ", " ", " ", " ", " ", " ", "█", "█", "█" },
               {"█", " ", " ", " ", " ", " ", " ", "█", "X", "█" },
               {"█", " ", "█", "█", "█", "█", "█", "█", " ", "█" },
               {"█", " ", " ", " ", " ", " ", " ", " ", " ", "█" },
               {"█", "█", "█", "█", "█", "█", "█", "█", "█", "█" }
            };
            MyWorld = new World(grid);
            Player = new Player(1, 1);

            RunUpdateLoop();
        }

        private void DisplayIntro()
        {
            WriteLine("Welcome to the maze!");
            WriteLine("\nInstructions");
            WriteLine("> Use the arrow keys to move");
            Write("> Try to reach the goal, which looks like this: ");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("X");
            ResetColor();
            WriteLine("> Press any key to start");
            ReadKey(true);
        }

        private void DisplayOutro()
        {
            Clear();
            WriteLine("You escaped!");
            WriteLine("Thanks for playing");
            WriteLine("Press any enter to exit...");
            ReadKey(true);
        }

        private void DrawFrame()
        {
            // Clear and redraw everything.
            Clear();
            MyWorld.Draw();
            Player.Draw();
        }

        private void HandlePlayerInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey(true);
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositionWalkable(Player.X, Player.Y - 1))
                        Player.Y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(Player.X, Player.Y + 1))
                        Player.Y += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(Player.X - 1, Player.Y))
                        Player.X -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(Player.X + 1, Player.Y))
                        Player.X += 1;
                    break;
                default:
                    break;
            }
        }

        private void RunUpdateLoop()
        {
            DisplayIntro();
            while (true)
            {
                // Draw everything.
                DrawFrame();

                // Check for the player input from the keyboard and move the player.
                HandlePlayerInput();

                // Check if the player has reached the exit and end the game if so.
                string playerWorldChar = MyWorld.GetElementAt(Player.X, Player.Y);
                if (playerWorldChar == "X")
                {
                    break;
                }

                // Give the Console window a chance to render.
                System.Threading.Thread.Sleep(20);
            }
            DisplayOutro();
        }
    }
}
