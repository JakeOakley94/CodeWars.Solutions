using System.Linq;
using System.Collections.Generic;

namespace CodeWars.Solutions._6KYU
{
    /// <summary>
    /// This Kata Can  Be Found At:
    /// </summary>
    public static class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            var odds = array.Where(x => x % 2 != 0).OrderBy(x => x).ToList();
            var dictionaryOfReplacements = new Dictionary<int, int>();
            var originalCurrentIndex = -1;
            var oddsCurrentIndex = 0;

            foreach (var item in array)
            {
                originalCurrentIndex++;
                if (item % 2 == 0) continue;
                dictionaryOfReplacements.Add(originalCurrentIndex, odds[oddsCurrentIndex]);
                oddsCurrentIndex++;
            }

            foreach (var kvp in dictionaryOfReplacements)
            {
                array[kvp.Key] = kvp.Value;
            }
            return array;
        }
    }
}
