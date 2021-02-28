using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        private string FullName;
        private int HappinessLevel;
        private string Species;
        private Toy CurrentToy;
        private ConsoleColor Color;

        public VirtualPet(string petName, int petHappiness, string petSpecies, ConsoleColor petColor)
        {
            FullName = petName;
            HappinessLevel = petHappiness;
            Species = petSpecies;
            Color = petColor;
        }

        public void Greet()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = Color;
            WriteLine($"My name is {FullName}, the {Species}!");
            DisplayHappinessBar();
            DisplayToyInfo();
            ForegroundColor = prevColor;
        }

        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }

        public void PickUpToy(Toy toy)
        {
            CurrentToy = toy;
        }

        private void DisplayToyInfo()
        {
            if (CurrentToy != null)
            {
                Write("I have a toy: ");
                CurrentToy.DisplayName();
                WriteLine();
            }
            else
            {
                WriteLine("I have no toy :(");
            }
        }

        private void DisplayHappinessBar()
        {
            Write("Happiness level: [");
            for (int i = 0; i < 10; i++)
            {
                if (i < HappinessLevel)
                {
                    Write("*");
                }
                else
                {
                    Write(" ");
                }
            }
            WriteLine("]");
        }
    }
}
