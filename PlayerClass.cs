using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public string gesture;
        public int personalScore;

        public List<string> gesturesList = new List<string>();

        public Player(string gesture, int personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
            AddGestures();
        }

        public void AddGestures()
        {
            gesturesList.Add("rock");
            gesturesList.Add("paper");
            gesturesList.Add("scissors");
            gesturesList.Add("lizard");
            gesturesList.Add("spock");
        }

        public abstract string ChooseGesture();

        // hold information about players
        // (which gesture / win counter)
    }
}