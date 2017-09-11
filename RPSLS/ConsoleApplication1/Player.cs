using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is the parent class for human user and AI
namespace ConsoleApplication1
{
    class Player
    {
        public string name;
        public int wins = 0;
        public virtual int PlayerPick()
        {
            Console.WriteLine(name + " Enter '1' for Rock, '2' for Paper, '3' for Scissors, '4' for Lizard, '5' for Spock\n");
            int userPick = 0;
            try
            {
                userPick = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(name + " Please Enter a valid option.");
                userPick = PlayerPick();
                return userPick;
            }
            if (userPick == 1 || userPick == 2 || userPick == 3 || userPick == 4 || userPick == 5)
            {
                return userPick;
            }
            else
            {
                Console.WriteLine(name + " Please Enter a valid option.");
                PlayerPick();
            }
            return userPick;
        }
    }
}
