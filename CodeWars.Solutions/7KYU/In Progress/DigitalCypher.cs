using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Solutions._7KYU.In_Progress
{
    /// <summary>
    /// This Kata can be found at:
    /// </summary>
    public class DigitalCypher
    {
        public static Dictionary<char, int> charToValueMappings = new Dictionary<char, int>()
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26},
        };

        public static int[] Encode(string str, int n)
        {
            int[] preShift = new int[str.Length];
            int currentIndex = 0;

            foreach (var @char in str)
            {
                preShift[currentIndex] = charToValueMappings[@char];
                currentIndex++;
            }

            var nToString = n.ToString();
            currentIndex = 0;
            int currentStringIndex = 0;
            int[] afterShift = new int[str.Length];

            foreach (var preshiftValue in preShift)
            {
                if (currentStringIndex + 1 > nToString.Length)
                {
                    currentStringIndex = 0;
                }

                afterShift[currentIndex] = preshiftValue + int.Parse(nToString[currentStringIndex].ToString());
                currentStringIndex++;
                currentIndex++;
            }
            return afterShift;
        }


    }
}
