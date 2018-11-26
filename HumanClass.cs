using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        public int humanInput;

        public Human(string gesture, int personalScore, int humanInput)
            :base(gesture, personalScore)
        {
            this.gesture = gesture;
            this.personalScore = personalScore;
            this.humanInput = humanInput;
        }

        public override string ChooseGesture()
        {
            string choiceDialoge = "------------------- \n";
            choiceDialoge += "Choose a gesture: \n";
            choiceDialoge += "Rock \n";
            choiceDialoge += "Paper \n";
            choiceDialoge += "Scissors \n";
            choiceDialoge += "Lizard \n";
            choiceDialoge += "Spock \n";
            choiceDialoge += "-------------------";
            Console.WriteLine(choiceDialoge);
            string choice;
            switch (Console.ReadLine().ToLower())
            {
                case "rock":
                    choice = "rock";
                    break;
                case "paper":
                    choice = "paper";
                    break;
                case "scissors":
                    choice = "scissors";
                    break;
                case "lizard":
                    choice = "lizard";
                    break;
                case "spock":
                    choice = "spock";
                    break;
                default:
                    Console.WriteLine("Invalid Input, make sure you spelled it correctly!");
                    ChooseGesture();
                    choice = "something";
                    break;
            }
            return choice;
        }
    }
}