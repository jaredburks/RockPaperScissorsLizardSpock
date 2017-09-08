using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This will be the parent class for human user and AI user
namespace ConsoleApplication1
{
    class Player
    {
        public string PlayerPick()
        {
            Console.WriteLine("Enter 'r' for Rock, 'p' for Paper, 'z' for Scissors, 'l' for Lizard, 'k' for Spock");
            string userPick = Console.ReadLine();
            return userPick;
        }
    }
}
