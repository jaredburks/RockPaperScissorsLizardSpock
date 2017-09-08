using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class will take human input. Child of Player class
namespace ConsoleApplication1
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            wins = 0;
        }
        public int PlayerPick()
        {
            Console.WriteLine("Enter '1' for Rock, '2' for Paper, '3' for Scissors, '4' for Lizard, '5' for Spock");
            int userPick = Convert.ToInt32(Console.ReadLine());
            if (userPick != 1 || userPick != 2 || userPick != 3 || userPick != 4 || userPick != 5)
            {
                Console.WriteLine(name + " Please Enter a valid option.");
                PlayerPick();
            }
            return userPick;
        }
    }
}
