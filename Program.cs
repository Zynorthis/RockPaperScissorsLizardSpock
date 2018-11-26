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
            GameClass GameHandler = new GameClass(0, false, 0, true); //Object Handling game counters/conditionals
            GameHandler.GameInitializer();
            int options;
            options = PlayerInitializer();

            if (options == 1)
            {
                PlayerClass Player1 = new HumanClass("none", 0, 0);
                PlayerClass Player2 = new AIClass("none", 0, 0);
            }
            else if (options == 2)
            {
                PlayerClass Player1 = new HumanClass("none", 0, 0);
                PlayerClass Player2 = new HumanClass("none", 0, 0);
            }
            else
            {
                Console.WriteLine("Huh?");
            }
        }
    }
}
