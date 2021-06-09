using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.Solutions._6KYU
{
    public static class ChessFunBishopAndPawn
    {
        public static bool BishopAndPawn(string bishop, string pawn)
        {
            List<char> columnPositions = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            List<int> rowPositions = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            char bishopColumn = bishop[0];
            int columnIndex = columnPositions.IndexOf(bishopColumn);
            List<string> bishopPossibleCaptures = new List<string>();

            for (int i = columnIndex + 1; i <= 7; i++)
            {
                bishopPossibleCaptures.Add($"{columnPositions[i]}{rowPositions[i]}");
            }
            for (int i = columnIndex - 1; i >= 0; i--)
            {
                bishopPossibleCaptures.Add($"{columnPositions[i]}{rowPositions[i]}");
            }

            return bishopPossibleCaptures.Contains(pawn);
        }
    }
}
