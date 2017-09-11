using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class will take AI input.
namespace ConsoleApplication1
{
    class AI : Player
    {
        public AI(string name)
        {
            this.name = name;
        }
        public override int PlayerPick()
        {
            Random num = new Random();
            int aiPick = num.Next(1, 6); //>= 1 and < 6. 1-Rock, 2-Paper, 3-Scissors, 4-Lizard, 5-Spock.
            return aiPick;
        }
    }
}
