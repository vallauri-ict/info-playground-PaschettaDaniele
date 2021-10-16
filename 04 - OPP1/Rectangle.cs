﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___OPP1
{
    class Rectangle
    {
        public int side1, side2;

        public Rectangle() : this(1)
        {

        }

        Rectangle (int lato) : this(lato, lato)
        {
        }

        public Rectangle (int lato1, int lato2)
        {
            side1 = lato1;
            side2 = lato2;
        }
    }
}
