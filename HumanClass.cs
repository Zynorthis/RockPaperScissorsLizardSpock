using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class HumanClass : PlayerClass
    {
        public int humanInput;

        public HumanClass(string gesture, int personalScore, int humanInput)
            :base(gesture, personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
            this.humanInput = humanInput;
        }

        public override int ChooseGesture()
        {
            return 0; // take human input
        }
    }
}