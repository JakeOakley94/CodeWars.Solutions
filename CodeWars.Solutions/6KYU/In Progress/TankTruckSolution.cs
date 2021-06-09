using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Solutions._6KYU
{
    /// <summary>
    /// This Kata can be found at : https://www.codewars.com/kata/55f3da49e83ca1ddae0000ad/
    /// </summary>
    public static class TankTruckSolution
    {
        public static class VolTank
        {
            public static int TankVol(int h, int d, int vt)
            {

                var r = d / 2;

                //Area of Segment = cos - 1(r − hr) r2 − (r − h) √(2rh − h2)
                return (int)Math.Floor((Math.Pow(Math.Cos(r - h / r), -1) * (r * 2) - (r - h) * Math.Sqrt((2 * r * h) - Math.Pow(h, 2))));
            }
        }
    }
}
