using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Solutions._6KYU.In_Progress
{
    public static class PrizeDraw
    {
        public static string NthRank(string st, int[] we, int n)
        {

            var namesToList = st.Split(',').ToList();
            PrizeDrawer prizeDrawer = new PrizeDrawer(namesToList, we);
            var results = prizeDrawer.NameToRankMappings.OrderByDescending(x => x.Rank);

            return null;


            // order alphbetically for duplicate ranks -- implement.
            // var resultRanks = results.Select(x => x.Rank).ToList();
            //var anyDuplicate = resultRanks.GroupBy(x => x).Any(g => g.Count() > 1);
            //if (anyDuplicate)
            //{
            //    var duplicates = resultRanks.GroupBy(s => s).SelectMany(grp => grp.Skip(1)).Distinct();
            //}


        }

        public class PrizeDrawer
        {
            private int[] weights;

            public List<LetterToRankMapping> LetterToRankMappings { get; set; }
            public List<string> NamesList { get; set; }
            public List<NameToRankMapping> NameToRankMappings { get; set; }


            public PrizeDrawer(List<string> namesList, int[] we)
            {
                NamesList = namesList;
                weights = we;
                GenerateLetterToRankMappings();
                GenerateNameToRankMappings();
            }

            private void GenerateLetterToRankMappings()
            {
                LetterToRankMappings.Add(new LetterToRankMapping('A', 1));
                LetterToRankMappings.Add(new LetterToRankMapping('B', 2));
                LetterToRankMappings.Add(new LetterToRankMapping('C', 3));
                LetterToRankMappings.Add(new LetterToRankMapping('D', 4));
                LetterToRankMappings.Add(new LetterToRankMapping('E', 5));
                LetterToRankMappings.Add(new LetterToRankMapping('F', 6));
                LetterToRankMappings.Add(new LetterToRankMapping('G', 7));
                LetterToRankMappings.Add(new LetterToRankMapping('H', 8));
                LetterToRankMappings.Add(new LetterToRankMapping('I', 9));
                LetterToRankMappings.Add(new LetterToRankMapping('J', 10));
                LetterToRankMappings.Add(new LetterToRankMapping('K', 11));
                LetterToRankMappings.Add(new LetterToRankMapping('L', 12));
                LetterToRankMappings.Add(new LetterToRankMapping('M', 13));
                LetterToRankMappings.Add(new LetterToRankMapping('N', 14));
                LetterToRankMappings.Add(new LetterToRankMapping('O', 15));
                LetterToRankMappings.Add(new LetterToRankMapping('P', 16));
                LetterToRankMappings.Add(new LetterToRankMapping('Q', 17));
                LetterToRankMappings.Add(new LetterToRankMapping('R', 18));
                LetterToRankMappings.Add(new LetterToRankMapping('S', 19));
                LetterToRankMappings.Add(new LetterToRankMapping('T', 20));
                LetterToRankMappings.Add(new LetterToRankMapping('U', 21));
                LetterToRankMappings.Add(new LetterToRankMapping('V', 22));
                LetterToRankMappings.Add(new LetterToRankMapping('W', 23));
                LetterToRankMappings.Add(new LetterToRankMapping('X', 24));
                LetterToRankMappings.Add(new LetterToRankMapping('Y', 25));
                LetterToRankMappings.Add(new LetterToRankMapping('Z', 26));
            }

            private void GenerateNameToRankMappings()
            {
                int currentIndex = 0;

                foreach (var name in NamesList)
                {
                    var currentWeight = weights[0];
                    var som = 0;

                    foreach (char letter in name)
                    {
                        som += LetterToRankMappings.Where(x => x.Char == char.ToUpper(letter)).FirstOrDefault().Rank;
                    }

                    som += name.Length;
                    som = som * currentWeight;
                    NameToRankMappings.Add(new NameToRankMapping(name, som));
                    currentIndex++;
                }
            }

        }

        public class LetterToRankMapping
        {
            public char Char { get; set; }
            public int Rank { get; set; }

            public LetterToRankMapping(char @char, int rank)
            {
                Char = @char;
                Rank = rank;
            }
        }

        public class NameToRankMapping
        {
            public string Name { get; set; }
            public int Rank { get; set; }
            public NameToRankMapping(string name, int rank)
            {
                Name = name;
                Rank = rank;
            }
        }


    }
}
