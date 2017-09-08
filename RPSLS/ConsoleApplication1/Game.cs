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
            int firstPick = player1.PlayerPick();
            int secondPick = player2.PlayerPick();


        }
    }
}
