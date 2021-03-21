using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceGameDemo
{
    class Game
    {
        public Game()
        {
        }

        public void Run()
        {
            WriteLine("##### Micro RPG #####\n");

            WaitForKey();
        }

        private void WaitForKey()
        {
            WriteLine("Press any key to continue...\n");
            ReadKey(true);
        }
    }
}
