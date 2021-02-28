using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace VirtualPetSimulator
{
    class Toy
    {
        private string Name;
        private ConsoleColor Color;

        public Toy(string toyName, ConsoleColor toyColor)
        {
            Color = toyColor;
            Name = toyName;
        }

        public void DisplayName()
        {
            ConsoleColor prevBgColor = BackgroundColor;
            ConsoleColor prevFgColor = ForegroundColor;
            BackgroundColor = Color;
            ForegroundColor = ConsoleColor.White;
            Write(Name);
            BackgroundColor = prevBgColor;
            ForegroundColor = prevFgColor;
        }
    }
}
