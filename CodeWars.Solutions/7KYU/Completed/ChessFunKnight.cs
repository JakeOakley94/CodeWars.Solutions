using System.Linq;
using System.Collections.Generic;
using System;

namespace CodeWars.Solutions._7KYU.In_Progress
{
    /// <summary>
    /// This Kata can be found at : https://www.codewars.com/kata/589433358420bf25950000b6/
    /// </summary>
    public static class ChessFunKnight
    {
        public class Move
        {
            public int XAxisChange { get; set; }
            public int YAxisChange { get; set; }
        }

        public class Knight
        {
            public List<Move> PossibleMoves { get; set; }

            public Knight()
            {
                PopulatePossibleMoves();
            }

            private void PopulatePossibleMoves()
            {
                PossibleMoves = new List<Move>();
                List<int> verticalMoves = new List<int>() { 1, 2, -1, -2 };
                List<int> horizontalMoves = new List<int>() { 1, 2, -1, -2 };
                PossibleMoves = horizontalMoves.SelectMany(g => verticalMoves.Select(c => new Move { XAxisChange = g, YAxisChange = c })).ToList();
                List<Move> invalidMoves = new List<Move>();

                foreach (var move in PossibleMoves)
                {
                    if (Math.Abs(move.YAxisChange) == Math.Abs(move.XAxisChange))
                    {
                        invalidMoves.Add(move); 
                    }
                }

                foreach(var invalidMove in invalidMoves)
                {
                    PossibleMoves.Remove(invalidMove);
                }
            }
        }

        public static int ChessKnight(string cell)
        {
            var boardColumns = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            var boardRows = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var knightColumn = boardColumns.IndexOf(cell[0]) + 1;
            var knightRow = boardRows.IndexOf(int.Parse(cell[1].ToString())) + 1;
            var knight = new Knight();
            var validMoves = 0;

            foreach (var possibleMove in knight.PossibleMoves)
            {
                var knightColumnAfterMove = knightColumn + possibleMove.YAxisChange;
                var knightRowAfterMove = knightRow + possibleMove.XAxisChange;

                if (knightColumnAfterMove > 8 || knightColumnAfterMove < 1) continue;
                if (knightRowAfterMove > 8 || knightRowAfterMove < 1) continue;
                validMoves++;
            }

            return validMoves;
        }
    }
}
