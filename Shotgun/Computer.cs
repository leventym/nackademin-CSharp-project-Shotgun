using System;
using System.Collections.Generic;
using System.Text;

namespace Shotgun
{
    public class Computer
    {
        public enum state
        {
            load,
            shoot,
            block,
            shotgun
        }
        public Computer()
        {
        }

        public state GetMove()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 2);  // creates a number between 0 and 3
            return (state)value; //casting enum number
        }


    }
}
