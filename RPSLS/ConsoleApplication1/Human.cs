﻿using System;
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
        }
    }
}
