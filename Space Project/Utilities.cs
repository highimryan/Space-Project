﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace SpaceTrader
{
    public static class Utility
    {
        public static double WarpSpeedToLightSpeed(double w)
        {
            if ((w <= 0) || (w > 9.5)) throw new ArgumentOutOfRangeException();

            return Math.Pow(w, 10.0 / 3) + Math.Pow(10 - w, -11.0 / 3);
        }
    }
}