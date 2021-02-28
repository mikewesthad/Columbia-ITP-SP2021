using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace VirtualPetSimulator
{
    class World
    {
        VirtualPet LeoTheCat;
        VirtualPet JuniorTheParrot;
        VirtualPet CallieTheUnicorn;
        Toy Ball;
        Toy SqueakToy;

        public World()
        {
            LeoTheCat = new VirtualPet("Leo", 10, "Cat", ConsoleColor.DarkMagenta);
            JuniorTheParrot = new VirtualPet("Junior", 5, "Parrot", ConsoleColor.DarkYellow);
            CallieTheUnicorn = new VirtualPet("Callie", 2, "Unicorn", ConsoleColor.DarkCyan);
            Ball = new Toy("Red Ball", ConsoleColor.Red);
            SqueakToy = new Toy("Squeak Toy", ConsoleColor.DarkGreen);
        }

        public void Run()
        {
            Title = "=== Virtual Pet Simulator ===";

            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Clear();

            WriteLine(@" _   _ _      _               _  ______    _   
| | | (_)    | |             | | | ___ \  | |  
| | | |_ _ __| |_ _   _  __ _| | | |_/ /__| |_ 
| | | | | '__| __| | | |/ _` | | |  __/ _ \ __|
\ \_/ / | |  | |_| |_| | (_| | | | | |  __/ |_ 
 \___/|_|_|   \__|\__,_|\__,_|_| \_|  \___|\__|");
            WriteLine("\nWelcome to the pet simulator!");

            WriteLine("\n\n> Pet 1");
            LeoTheCat.PickUpToy(Ball);
            LeoTheCat.Greet();
            LeoTheCat.Eat("some dry food");

            WriteLine("\n> Pet 2");
            JuniorTheParrot.PickUpToy(SqueakToy);
            JuniorTheParrot.Greet();
            JuniorTheParrot.Eat("a worm");

            WriteLine("\n> Pet 3");
            CallieTheUnicorn.Greet();
            CallieTheUnicorn.Eat("rainbows");

            WriteLine("\n\nPress any key to exit...");
            ReadKey();
        }
    }
}
