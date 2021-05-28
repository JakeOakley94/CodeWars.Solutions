using System;
using System.Numerics;

namespace CodeWars.Solutions._3KYU
{
    public static class LastDigitOfHugeNumber
    {
        public static int LastDigit(int[] array)
        {
            try
            {
                if (array.Length == 0) return 1;
                if (array.Length == 1) return array[0];

                if (array.Length == 2)
                {
                    var ourNumber2 = new BigInteger(Math.Pow(array[0], array[1]));
                    var charArray2 = ourNumber2.ToString().ToCharArray();
                    return int.Parse(charArray2[charArray2.Length - 1].ToString());
                }

                var ourNumber = new BigInteger(Math.Pow(array[0], Math.Pow(array[1], array[2])));
                var charArray = ourNumber.ToString().ToCharArray();
                return int.Parse(charArray[charArray.Length - 1].ToString());
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
