using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class will take human input.
namespace ConsoleApplication1
{
    class Human : Player
    {
        public Human()
        {
            name = Console.ReadLine();
        }
    }
}
