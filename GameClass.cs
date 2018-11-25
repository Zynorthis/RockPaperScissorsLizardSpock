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

        public GameClass GameInitializer(GameHandler)
        {
            // Run everything here
        }

        public int PlayerCounter(int playerCount)
        {
            Console.WriteLine("How Many Players will there be? (Choose between 2-4)");
            int NumberOfPlayers = Int32.Parse(Console.ReadLine());
            switch (NumberOfPlayers){
                
                case 2:
                    playerCount = 2;
                    return playerCount;
                case 3:
                    playerCount = 3;
                    return playerCount;
                case 4:
                    playerCount = 4;
                    return playerCount;
                default:
                    Console.WriteLine(errorMessage);
                    PlayerCounter(playerCount);
                    break;
            }
        }

        public bool Mode(bool isSinglePlayer)
        {
            Console.WriteLine("Do you want to play single player or multiplayer?");
            switch (Console.ReadLine())
            {
                case "single":
                    isSinglePlayer = true;
                    return isSinglePlayer;
                case "multiplayer":
                    isSinglePlayer = false;
                    return isSinglePlayer;
                default:
                    Console.WriteLine(errorMessage);
                    Mode(isSinglePlayer);
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
                    Console.WriteLine(errorMessage+"/n"+"The rounds need to be an odd amount or it may end in a draw!");
                    Console.ReadLine();
                    RoundInitializer();
                }
                else
                {
                    return maxRounds;
                }
            }
        }


        // decide round winners
        // decide overall winner
        // select amount of rounds
    }
}
