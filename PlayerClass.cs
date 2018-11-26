using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class PlayerClass
    {
        public string gesture;
        public int personalScore;

        public List<string> gestures = new List<string>();

        public PlayerClass(string gesture, int personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
        }

        public List<string> AddGestures()
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");

            return gestures;
        }

        public abstract int ChooseGesture();

        // hold information about players
        // (which gesture / win counter)
    }
}