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

        public override void ChooseGesture()
        {
            Random rng = new Random();
            int gestureRoll = rng.Next(5);
            Console.WriteLine("DevTesting: " + gestureRoll);
            switch (gestureRoll)
            {
                case 0:
                    gesture = "rock";
                    break;
                case 1:
                    gesture = "paper";
                    break;
                case 2:
                    gesture = "scissors";
                    break;
                case 3:
                    gesture = "lizard";
                    break;
                case 4:
                    gesture = "spock";
                    break;
                default:
                    Console.WriteLine("Invalid Input, make sure you spelled it correctly!");
                    ChooseGesture();
                    break;
            }
        }
    }
}