using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Solutions._6KYU
{
    public static class MultiplesOf3Or5
    {
        public static int Solution(int value) => Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }
}
