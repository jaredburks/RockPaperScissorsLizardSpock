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
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock!!\nPlay Single Player or 2 Player?\nEnter '1' For Single Player, '2' For 2 Player");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("You choose Single Player. Best of 3 wins. GO!");
                    //TODO: Call fucnction

                    break;
                case "2":
                    Console.WriteLine("You choose 2 Player. Best of 3 wins. GO!");
                    //TODO: Call fucnction

                    break;
                default:
                    Console.WriteLine("Invalid Option. Please Enter '1' or '2'");
                    Versus();
                    break;
            }

        }

        public void Match()
        {

        }
    }
}
