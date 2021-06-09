using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Solutions._6KYU
{
    public static class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            var listUnsorted = new List<string>();

            foreach (var item in array1)
            {
                list1.Add(item.Split(',').ToString());
            }

            foreach (var item in array1)
            {
                list2.Add(item.Split(',').ToString());
            }

            foreach(var word in list1)
            {
                if(list2.Any(x => x.Contains(word)))
                {
                    listUnsorted.Add(word);
                }
            }
            return null;


        }
    }
}
