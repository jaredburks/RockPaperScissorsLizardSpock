using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Rock Paper Scissors Lizard Spock
Create a console application for Rock, Paper, Scissors, Lizard, Spock
=========Your game should have the option of Single player (vs AI) or 2 player (Human vs Human)
=========Your game must be a minimum of best of three to decide a winner
Rules for Rock, Paper, Scissors, Lizard, Spock:
Scissors cuts Paper
Paper covers Rock
Rock crushes Lizard
Lizard poisons Spock
Spock smashes Scissors
Scissors decapitates Lizard
Lizard eats Paper
Paper disproves Spock
Spock vaporizes Rock
(and as it always has) Rock crushes Scissors
 * 
*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void Versus()//Switch case to handle player vs AI or player vs player
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock!!\nPlay Single Player or 2 Player?\nEnter '1' For Single Player, '2' For 2 Player");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("You choose Single Player. Best of 3 wins. GO!");
                    SinglePlayer();
                    break;
                case "2":
                    Console.WriteLine("You choose 2 Player. Best of 3 wins. GO!");
                    TwoPlayer();
                    break;
                default:
                    Console.WriteLine("Invalid Option. Please Enter '1' or '2'");
                    Versus();
                    break;
            }

        }

        public void SinglePlayer()
        {
            Console.WriteLine("Enter 'r' for Rock, 'p' for Paper, 'z' for Scissors, 'l' for Lizard, 'k' for Spock");
            string userPick = Console.ReadLine();
        }

        public void TwoPlayer()
        {

        }

        public void AiChoice()
        {

        }
    }
}
