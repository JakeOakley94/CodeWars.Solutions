using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Solutions._4KYU
{
    /// <summary>
    /// This kata can be found at: 
    /// </summary>
    /// 
    public static class IntParserReloaded
    {
        public enum NumberBase
        {
            Tens,
            Hundreds,
            Thousands,
            Millions,
        }

        public static int ParseInt(string s)
        {
            // set our string to uppercase so we can handle everything easily
            s = s.ToUpper();
            s = s.Replace('-', ' ');
            s = s.Replace(" ", string.Empty);

            // Detect if Hundred, thousand, million keywords are present. (We can logically test this with just hundred.
            NumberBase baseType = GetNumberBase(s);

            switch (baseType)
            {
                case (NumberBase.Tens):
                    return ParseTensBaseNumber(s);
                case (NumberBase.Hundreds):
                    return ParseHundredBaseNumber(s);
                case (NumberBase.Thousands):
                    return ParseThousandBaseNumber(s);
                case (NumberBase.Millions):
                    return ParseMillionBaseNumber(s);
                default:
                    return 0;
            }
        }

        private static Dictionary<string, int> PopulateStringToIntDictionary()
        {
            var toReturn = new Dictionary<string, int>();
            toReturn.Add("ONE", 1);
            toReturn.Add("TWO", 2);
            toReturn.Add("THREE", 3);
            toReturn.Add("FOUR", 4);
            toReturn.Add("FIVE", 5);
            toReturn.Add("SIX", 6);
            toReturn.Add("SEVEN", 7);
            toReturn.Add("EIGHT", 8);
            toReturn.Add("NINE", 9);
            toReturn.Add("TEN", 10);
            toReturn.Add("ELEVEN", 11);
            toReturn.Add("TWELVE", 12);
            toReturn.Add("THIRTEEN", 13);
            toReturn.Add("FOURTEEN", 14);
            toReturn.Add("FIFTEEN", 15);
            toReturn.Add("SIXTEEN", 16);
            toReturn.Add("SEVENTEEN", 17);
            toReturn.Add("EIGHTEEN", 18);
            toReturn.Add("NINETEEN", 19);
            toReturn.Add("TWENTY", 20);
            toReturn.Add("THIRTY", 30);
            toReturn.Add("FOURTY", 40);
            toReturn.Add("FIFTY", 50);
            toReturn.Add("SIXTY", 60);
            toReturn.Add("SEVENTY", 70);
            toReturn.Add("EIGHTY", 80);
            toReturn.Add("NINTY", 90);
            toReturn.Add("HUNDRED", 100);
            toReturn.Add("THOUSAND", 1000);
            toReturn.Add("MILLION", 1000000);
            return toReturn;
        }


        private static int ParseTensBaseNumber(string number)
        {
            var dictionary = PopulateStringToIntDictionary();
            if (dictionary.ContainsKey(number))
            {
                return dictionary[number];
            }
            else
            {
                // number must have a prefix (20, 30 etc)
                var indexOfTY = number.IndexOf("TY");
                var firstBase = number.Substring(0, indexOfTY + 2);

                var baseNumber = dictionary[firstBase];

                var numberReversed = new string(number.Reverse().ToArray());
                var numberTrimmedAndReversedBack = new string(numberReversed.Substring(0, number.Length - (indexOfTY + 2)).Reverse().ToArray());
                var secondNumber = dictionary[numberTrimmedAndReversedBack];
                return baseNumber + secondNumber;
            }
        }
        private static int ParseHundredBaseNumber(string number)
        {
            var dictionary = PopulateStringToIntDictionary();

            // number must have a prefix (20, 30 etc)
            var indexOfTY = number.IndexOf("HUNDRED");
            var firstBase = number.Substring(0, indexOfTY + 2);

            var baseNumber = dictionary[firstBase];

            var numberReversed = new string(number.Reverse().ToArray());
            var numberTrimmedAndReversedBack = new string(numberReversed.Substring(0, number.Length - (indexOfTY + 2)).Reverse().ToArray());
            var secondNumber = dictionary[numberTrimmedAndReversedBack];
            return baseNumber + secondNumber;
        }


        private static int ParseThousandBaseNumber(string number)
        {
            var dictionary = PopulateStringToIntDictionary();
            return 1;
        }

        private static int ParseMillionBaseNumber(string number)
        {
            var dictionary = PopulateStringToIntDictionary();
            return 1;
        }

        private static NumberBase GetNumberBase(string number)
        {
            if (number.Contains("MILLION"))
            {
                return NumberBase.Millions;
            }

            if (number.Contains("THOUSAND"))
            {
                return NumberBase.Thousands;
            }

            if (number.Contains("HUNDRED"))
            {
                return NumberBase.Hundreds;
            }

            return NumberBase.Tens;
        }

    }
}
