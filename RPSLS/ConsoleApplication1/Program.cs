using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Rock Paper Scissors Lizard Spock
Create a console application for Rock, Paper, Scissors, Lizard, Spock
Your game should have the option of Single player (vs AI) or 2 player (Human vs Human)
Your game must be a minimum of best of three to decide a winner
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
            Game game = new Game();
            game.Versus();
        }
    }
}
