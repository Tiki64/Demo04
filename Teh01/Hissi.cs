﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh01
{
    class Hissi
    {
        private int minfloor = 1;
        private int maxfloor = 5;
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= minfloor && value <= maxfloor)
                {
                    floor = value;
                }
                else if (value < 1)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > 5)
                {
                    Console.WriteLine("Floor is too big!");
                }


            }
        }
    }
}