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
            GameHandler.PlayerCounter(0);
            // Call GameClass here
        }
    }
}
