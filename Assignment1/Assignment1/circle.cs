﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class circle
    {
        static void Main()
        {
            //  The constant must be initialized it can not be assigned.
            const double PI = 3.14;
            //PI = 3.234;//Error
            int r = 5;
            double aoc = (r * r * PI);
            Console.WriteLine("Area of Circle is:{0}", aoc);
            Console.ReadLine();
        }
    }
}
