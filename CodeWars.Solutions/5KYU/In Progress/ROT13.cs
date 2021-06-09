using System;
using System.Collections.Generic;

namespace CodeWars.Solutions._5KYU.In_Progress
{
    public static class ROT13
    {
        public static List<char> charMappings = new List<char>()
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };


        public static string Rot13(string input)
        {
            char[] transformed = new char[input.Length];

            int currentIndex = -1;

            foreach (var @char in input)
            {
                currentIndex++;

                if (char.IsNumber(@char) || char.IsWhiteSpace(@char) || char.IsSymbol(@char) || char.IsSeparator(@char) || char.IsPunctuation(@char))
                {
                    transformed[currentIndex] = @char;
                    continue;
                }

                var charWasUpper = char.IsUpper(@char);
                var charToUpper = charWasUpper ? @char : char.ToUpper(@char);
                var indexOfChar = charMappings.IndexOf(charToUpper);
                // if current index + 13 overlaps,  take 13 - ( 25 - current index ) Ex = CurrentIndex = 20 , 20+ 13 > 25,  13 - (25 - 20 ) (Space Left) = 13 - 20 = (-7) = 7
                var applicableIndexAfterShift = indexOfChar + 13 > 25 ? Math.Abs(12 - (25 - indexOfChar)) : indexOfChar + 13;
                var applicableShiftChar = charWasUpper ? charMappings[applicableIndexAfterShift] : char.ToLower(charMappings[applicableIndexAfterShift]);
                transformed[currentIndex] = applicableShiftChar;
            }

            return new string(transformed);
        }
    }
}
