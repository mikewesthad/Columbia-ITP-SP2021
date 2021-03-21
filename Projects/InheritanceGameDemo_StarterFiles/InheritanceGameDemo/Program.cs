using System;

namespace InheritanceGameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Micro RPG";

            Game myGame = new Game();
            myGame.Run();
        }
    }
}
