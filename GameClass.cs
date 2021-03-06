﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        public int roundCounter;
        public bool overallWinner;
        public int playerCount;
        public bool isSinglePlayer;
        public int maxRounds;
        Player Player1;
        Player Player2;

        public string errorMessage = "That was not a valid input, please try again.";

        public Game(int roundCounter, bool overallWinner, int playerCount, bool isSinglePlayer)
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
            roundCounter++; // round starts at round one, not 0
            GameLoop();
        }

        public void GameLoop()
        {
            // everything runs here
            TurnHandler();
            if (Player1.personalScore >= ((maxRounds/2)+1) || Player2.personalScore >= ((maxRounds / 2) + 1))
            {
                //End of game intiates
                Console.Clear();
                Console.WriteLine("Game Over!");
                if (Player1.personalScore > Player2.personalScore)
                {
                    Console.WriteLine("Player 1 is the Winner!");
                    Console.ReadLine();
                }
                else if (Player2.personalScore > Player1.personalScore)
                {
                    Console.WriteLine("Player 2 is the Winner!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Something has gone horribly wrong to end up here...");
                    Console.ReadLine();
                }
            }
            else
            {
                GameLoop();
            }
        }

        public void PlayerCounter()
        {
            // only two players can play right now but support for more is in place.
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
            maxRounds = Int32.Parse(Console.ReadLine());
            if (maxRounds < 3 || maxRounds > 25)
            {
                switch (maxRounds)
                {
                    case (0):
                        Console.WriteLine("Huh?");
                        break;
                    default:
                        Console.WriteLine(errorMessage);
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        RoundInitializer();
                        break;
                }
                return maxRounds;
            }
            else if (maxRounds % 2 == 0)
            {
                switch (maxRounds)
                {
                    case (0):
                        Console.WriteLine("Huh?");
                        break;
                    default:
                        Console.WriteLine(errorMessage);
                        Console.WriteLine("Make sure that you enter in an odd number otherwise the players may draw!");
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        RoundInitializer();
                        break;
                }
                return maxRounds;
            }
            else
            {
                return maxRounds;
            }
        }

        public void PlayerInitializer()
        {
            // only two players are about to play right now but support for more is in place here.
            if (isSinglePlayer == true)
            {
                Player1 = new Human("none", 0, 0);
                Player2 = new AI("none", 0, 0);
            }
            else
            {
                Player1 = new Human("none", 0, 0);
                Player2 = new Human("none", 0, 0);
            }
            
            //List<Player> playerList = new List<Player>();
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
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("It is player 1's turn!");
            Player1.ChooseGesture();
            Console.Clear();
            Console.WriteLine("It is player 2's turn!");
            Player2.ChooseGesture();
            gestureComparision();
        }

        public void gestureComparision()
        {
            if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("It was a draw!");
                Console.ReadLine();
                TurnHandler();
            }
            else
            {
                // nested switches are here to decide what player won and increase counters accordingly.
                switch (Player1.gesture) { 
                    case "rock":
                        switch (Player2.gesture)
                        {
                            case "paper":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "lizard":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "spock":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                        }
                        break;
                    case "paper":
                        switch (Player2.gesture)
                        {
                            case "rock":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "lizard":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "spock":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                        }
                        break;
                    case "scissors":
                        switch (Player2.gesture)
                        {
                            case "paper":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "rock":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "lizard":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "spock":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                        }
                        break;
                    case "lizard":
                        switch (Player1.gesture)
                        {
                            case "paper":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "rock":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "spock":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                        }
                        break;
                    case "spock":
                        switch (Player2.gesture)
                        {
                            case "paper":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "scissors":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                            case "lizard":
                                Console.WriteLine("Player 2 won!");
                                Console.ReadLine();
                                Player2.personalScore++;
                                roundCounter++;
                                break;
                            case "rock":
                                Console.WriteLine("Player 1 won!");
                                Console.ReadLine();
                                Player1.personalScore++;
                                roundCounter++;
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Something went horribly wrong here...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}