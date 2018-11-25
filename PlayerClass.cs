using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class PlayerClass
    {
        public string gesture;
        public int personalScore;

        public PlayerClass(string gesture, int personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
        }

        // hold information about players
        // (which gesture / win counter)
    }
}
