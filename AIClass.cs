using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        public int aiInput;

        public AI(string gesture, int personalScore, int aiInput)
            :base(gesture, personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
            this.aiInput = aiInput;
        }

        public override string ChooseGesture()
        {
            Random rng = new Random();
            int gestureRoll = rng.Next(5);
            Console.WriteLine("DevTesting: " + gestureRoll);
            //this.gesture = gesturesList.ElementAt(gestureRoll);
            return gesturesList.ElementAt(gestureRoll);
        }
    }
}