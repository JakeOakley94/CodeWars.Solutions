using System;

namespace CodeWars.Solutions._6KYU
{
    public static class SmallestPermutation
    {
        public static int MinPermutation(int n)
        {
            if (n == 0) return 0;
            var wasNegative = n < 0;
            var smallestPermutation = FindSmallestPermutation(Math.Abs(n).ToString());
            if (wasNegative)
            {
                return int.Parse(new string(smallestPermutation)) * -1;
            }
            return int.Parse(new string(smallestPermutation));
        }


        static char[] FindSmallestPermutation(string s1)
        {

            char[] s = s1.ToCharArray(); ;
            Array.Sort(s);

            int i = 0;
            while (s[i] == '0')
                i++;

            char temp = s[0];
            s[0] = s[i];
            s[i] = temp;
            return s;
        }
    }
}
