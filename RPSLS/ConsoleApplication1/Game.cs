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
        List<string> list = new List<string>(new string[] { "rock", "paper", "scissors", "lizard", "Spock" });
        Player player1;
        Player player2;
        int round = 0;
        int firstPick;
        int secondPick;

        public void Rules()
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
        }
        public void Versus()
        {
            Rules();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("You chose Single Player (VS CPU). Best of 3 wins. GO!");
                    Console.WriteLine("Player 1 please enter your name.");
                    player1 = new Human();
                    player2 = new AI();
                    StartMatch();
                    break;
                case "2":
                    Console.WriteLine("You chose 2 Player. Best of 3 wins. GO!");
                    Console.WriteLine("Player 1 please enter your name.");
                    player1 = new Human();
                    Console.WriteLine("Player 2 please enter your name.");
                    player2 = new Human();
                    StartMatch();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please Enter '1' or '2'");
                    Versus();
                    break;
            }
        }

        public void FirstPlayerWin(int firstPick, int secondPick)
        {
            Console.WriteLine(player1.name + " Wins this round!");
            Console.WriteLine(player1.name + " Chose " + $"{list[firstPick - 1]}");
            Console.WriteLine(player2.name + " Chose " + $"{list[secondPick - 1]}" + "\n");
            player1.wins++;
        }

        public void FirstPlayerLose(int firstPick, int secondPick)
        {
            Console.WriteLine(player2.name + " Wins this round!");
            Console.WriteLine(player1.name + " Chose " + $"{list[firstPick - 1]}");
            Console.WriteLine(player2.name + " Chose " + $"{list[secondPick - 1]}" + "\n");
            player2.wins++;
        }

        public void DecideWinner()
        {
            if (player1.wins == 2)
            {
                Console.WriteLine("\n" + player1.name + " WINS THE MATCH!\n" + round + " Rounds were played.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n" + player2.name + " WINS THE MATCH!\n" + round + " Rounds were played.");
                Console.ReadLine();
            }
        }

        public void ComparePicks()
        {
            if (firstPick == secondPick)
            {
                Console.WriteLine("DRAW! REDO ROUND\n");
                round--;
            }
            else if (firstPick == 1) //If Player1 picks rock
            {
                if (secondPick == 3 || secondPick == 4)
                {
                    FirstPlayerWin(firstPick, secondPick);
                }
                else
                {
                    FirstPlayerLose(firstPick, secondPick);
                }
            }
            else if (firstPick == 2) //If Player1 picks paper
            {
                if (secondPick == 1 || secondPick == 5)
                {
                    FirstPlayerWin(firstPick, secondPick);
                }
                else
                {
                    FirstPlayerLose(firstPick, secondPick);
                }
            }
            else if (firstPick == 3) //If Player1 picks scissors
            {
                if (secondPick == 2 || secondPick == 4)
                {
                    FirstPlayerWin(firstPick, secondPick);
                }
                else
                {
                    FirstPlayerLose(firstPick, secondPick);
                }
            }
            else if (firstPick == 4) //If Player1 picks lizard
            {
                if (secondPick == 2 || secondPick == 5)
                {
                    FirstPlayerWin(firstPick, secondPick);
                }
                else
                {
                    FirstPlayerLose(firstPick, secondPick);
                }
            }
            else if (firstPick == 5) //If Player1 picks Spock
            {
                if (secondPick == 1 || secondPick == 3)
                {
                    FirstPlayerWin(firstPick, secondPick);
                }
                else
                {
                    FirstPlayerLose(firstPick, secondPick);
                }
            }
        }
        public void StartMatch()
        {
            while (player1.wins < 2 && player2.wins < 2)
            {
                round++;
                Console.WriteLine("Round: " + round + "\n");
                firstPick = player1.PlayerPick();
                secondPick = player2.PlayerPick();
                ComparePicks();
            }
            DecideWinner();
        }
    }
}
