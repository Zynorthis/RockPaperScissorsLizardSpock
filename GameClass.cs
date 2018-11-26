using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class GameClass
    {
        public int roundCounter;
        public bool overallWinner;
        public int playerCount;
        public bool isSinglePlayer;

        public string errorMessage = "That was not a valid input, please try again.";

        public GameClass(int roundCounter, bool overallWinner, int playerCount, bool isSinglePlayer)
        {
            this.roundCounter = roundCounter;
            this.overallWinner = overallWinner;
            this.playerCount = playerCount;
            this.isSinglePlayer = isSinglePlayer;
        }

        public void GameInitializer()
        {
            // setting things up based on player input
            Mode();
            if (isSinglePlayer == false)
            {
                PlayerCounter();
            }
            RoundInitializer();
            PlayerInitializer();
            GameLoop();
        }

        public void GameLoop()
        {
            // everything runs here
            TurnHandler();
        }

        public void PlayerCounter()
        {
            Console.WriteLine("How Many Players will there be? (Choose between 2-4)");
            int NumberOfPlayers = Int32.Parse(Console.ReadLine());
            switch (NumberOfPlayers){
                
                case 2:
                    playerCount = 2;
                    break;
                //case 3:
                    //playerCount = 3;
                    //break;
                //case 4:
                    //playerCount = 4;
                    //break;
                default:
                    Console.WriteLine(errorMessage);
                    PlayerCounter();
                    break;
            }
        }

        public void Mode()
        {
            Console.WriteLine("Do you want to play single player or multiplayer?");
            switch (Console.ReadLine())
            {
                case "single":
                    isSinglePlayer = true;
                    break;
                case "multiplayer":
                    isSinglePlayer = false;
                    break;
                default:
                    Console.WriteLine(errorMessage);
                    Mode();
                    break;
            }
        }

        public int RoundInitializer()
        {
            Console.WriteLine("How many rounds would you like to play (minimum:3 / Maximum:25)");
            int maxRounds = Int32.Parse(Console.ReadLine());
            if (maxRounds < 3 || maxRounds > 25)
            {
                Console.WriteLine(errorMessage);
                Console.ReadLine();
                RoundInitializer();
            }
            else {
                if (maxRounds%2 == 0)
                {
                    Console.WriteLine(errorMessage + "\n" + "The rounds need to be an odd amount or the game may end in a draw!");
                    Console.ReadLine();
                    RoundInitializer();
                }
            }
            return maxRounds;
        }

        public int PlayerInitializer()
        {
            if (isSinglePlayer == true)
            {
                int options = 1;
                return options;
            }
            else
            {
                int options = 2;
                return options;
            }

            //List<PlayerClass> playerList = new List<PlayerClass>();
            //playerList.Capacity = playerCount;
            //foreach (int index in playerList)
            //{
                //playerList.Add(player+index);
                //index++;
            //}
        }

        public void TurnHandler()
        {
            Console.WriteLine("Round " + roundCounter + "!");
            Console.Clear();
            Player1.ChooseGesture();
            Console.Clear();
            Player2.ChooseGesture();
            Console.Clear();

        }

        // decide round winners
        // decide overall winner
        // select amount of rounds
    }
}