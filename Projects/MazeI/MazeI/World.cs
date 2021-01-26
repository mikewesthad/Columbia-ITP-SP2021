using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MazeI
{
    class World
    {
        private string[,] Grid;
        private int GridWidth;
        private int GridHeight;

        public World(string[,] grid)
        {
            Grid = grid;
            GridWidth = Grid.GetLength(1);
            GridHeight = Grid.GetLength(0);
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }

        public void SetElementAt(int x, int y, string element)
        {
            Grid[y, x] = element;
        }

        public void Draw()
        {
            for (int y = 0; y < GridHeight; y++)
            {
                for (int x = 0; x < GridWidth; x++)
                {
                    string element = GetElementAt(x, y);
                    SetCursorPosition(x, y);

                    if (element == "X")
                    {
                        ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }

                    Write(element);
                }
            }
        }

        public bool IsPositionWalkable(int x, int y)
        {
            // Check bounds first.
            if (x < 0 || x >= GridWidth || y < 0 || y >= GridHeight)
            {
                return false;
            }

            // Check if the grid is a walkable tile.
            return GetElementAt(x, y) == " " || GetElementAt(x, y) == "X";

            // Equivalent to:
            //if (GetElementAt(x,y) == " ")
            //{
            //    return true;
            //} 
            //else if (GetElementAt(x,y) == "X")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
