using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class takes input from Human and AI and compares input.
namespace ConsoleApplication1
{
    class Game
    {
        public void Versus()//Switch case to handle player vs AI or player vs player
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("Rules:");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("And as it always has Rock crushes Scissors");
            Console.WriteLine("\nEnter '1' For Single Player, '2' For 2 Player");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("You chose Single Player. Best of 3 wins. GO!");
                    //TODO: Call fucnction
                    PlayerAiMatch();
                    break;
                case "2":
                    Console.WriteLine("You chose 2 Player. Best of 3 wins. GO!");
                    //TODO: Call fucnction

                    break;
                default:
                    Console.WriteLine("Invalid Option. Please Enter '1' or '2'");
                    Versus();
                    break;
            }
        }

        public void PlayerAiMatch()
        {
            Human player1 = new Human("Player1");
            AI player2 = new AI("CPU");
            int round = 0;

            while (player1.wins < 2 || player2.wins < 2)
            {
                round++;
                Console.WriteLine("Round: " + round);
                int firstPick = player1.PlayerPick();
                int secondPick = player2.PlayerPick();

                if (firstPick == secondPick)
                {
                    Console.WriteLine("DRAW! REDO ROUND");
                    round--;
                }
                else if (firstPick == 1) //If Player1 picks rock
                {
                    if (secondPick == 3 || secondPick == 4) //WIN Scenario
                    {
                        Console.WriteLine(player1.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player1.wins++;
                    }
                    else //Lose Scenario
                    {
                        Console.WriteLine(player2.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player2.wins++;
                    }
                }
                else if (firstPick == 2) //If Player1 picks paper
                {
                    if (secondPick == 1 || secondPick == 5) //WIN Scenario
                    {
                        Console.WriteLine(player1.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player1.wins++;
                    }
                    else //Lose Scenario
                    {
                        Console.WriteLine(player2.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player2.wins++;
                    }
                }
                else if (firstPick == 3) //If Player1 picks scissors
                {
                    if (secondPick == 2 || secondPick == 4) //WIN Scenario
                    {
                        Console.WriteLine(player1.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player1.wins++;
                    }
                    else //Lose Scenario
                    {
                        Console.WriteLine(player2.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player2.wins++;
                    }
                }
                else if (firstPick == 4) //If Player1 picks lizard
                {
                    if (secondPick == 2 || secondPick == 5) //WIN Scenario
                    {
                        Console.WriteLine(player1.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player1.wins++;
                    }
                    else //Lose Scenario
                    {
                        Console.WriteLine(player2.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player2.wins++;
                    }
                }
                else if (firstPick == 5) //If Player1 picks Spock
                {
                    if (secondPick == 1 || secondPick == 3) //WIN Scenario
                    {
                        Console.WriteLine(player1.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player1.wins++;
                    }
                    else //Lose Scenario
                    {
                        Console.WriteLine(player2.name + " Wins this round!");
                        Console.WriteLine(player1.name + " Chose " + firstPick);
                        Console.WriteLine(player2.name + " Chose " + secondPick);
                        player2.wins++;
                    }
                }
            }
        }
    }
}
