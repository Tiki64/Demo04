﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Boss : Employee
    {
        public int Bonus { get; set; }
        public string Car { get; set; }

        public Boss()
        {

        }

        public Boss(string name, string profession, int salary, string car, int bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + ", Car: " + Car + ", Bonus: " + Bonus;
        }
    }
}