using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class AIClass : PlayerClass
    {
        public int aiInput;

        public AIClass(string gesture, int personalScore, int aiInput)
            :base(gesture, personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
            this.aiInput = aiInput;
        }

        // take AI input (Randomly decide things)
    }
}
