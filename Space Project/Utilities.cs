using System;

namespace SpaceTrader
{
    public static class Utilities
    {


        public static double WarpSpeedToLightSpeed(double w)
        {
            //   Trying to add an if statement that randomly generates a number... the chosen warpspeed is equal to the randomly generated number, then you get raided... not working. 
            //    if (w == Random.Next())     
            //    {
            //        Console.WriteLine("You have been raided!");
            //    }

            if (w <= 0 || w > 9.5) throw new ArgumentOutOfRangeException();

            return Math.Pow(w, 10.0 / 3) + Math.Pow(10 - w, -11.0 / 3);

        }
        




    }
} 