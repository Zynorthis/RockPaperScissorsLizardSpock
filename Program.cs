using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game GameHandler = new Game(0, false, 0, true); // Object Handling game counters/conditionals
            GameHandler.GameInitializer();
        }
    }
}