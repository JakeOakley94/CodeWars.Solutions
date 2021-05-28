using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CodeWars.Solutions._6KYU.In_Progress
{
    public static class ChessFunChessBoardColor
    {
        public static bool ChessBoardCellColor(string cell1, string cell2)
        {
            var boardColumnLetterMappings = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            var chessBoard = new ChessBoard();

            int xPos1 = boardColumnLetterMappings.IndexOf(cell1[0]) + 1;
            int yPos1 = int.Parse(cell1[1].ToString());
            int xPos2 = boardColumnLetterMappings.IndexOf(cell2[0]) + 1;
            int yPos2 = int.Parse(cell2[1].ToString());

            var square1 = chessBoard.Squares.Single(x => x.XAxisLocation == xPos1 && x.YAxisLocation == yPos1);
            var square2 = chessBoard.Squares.Single(x => x.XAxisLocation == xPos2 && x.YAxisLocation == yPos2);
            return square1.Color == square2.Color;
        }

        public class ChessBoard
        {
            public List<ChessBoardSquare> Squares { get; set; }

            public ChessBoard()
            {
                GenerateBoardSquares();
            }

            private void GenerateBoardSquares()
            {
                Squares = new List<ChessBoardSquare>();
                Color startColor = Color.Black;

                for (int i = 1; i <= 8; i++)
                {
                    startColor = i % 2 == 0 ? Color.Black : Color.White;

                    for (int j = 1; j <= 8; j++)
                    {
                        Squares.Add(new ChessBoardSquare(i, j, startColor));
                        startColor = startColor == Color.Black ? Color.White : Color.Black;
                    }
                }
            }
        }


        public class ChessBoardSquare
        {
            public int XAxisLocation { get; set; }
            public int YAxisLocation { get; set; }
            public Color Color { get; set; }

            public ChessBoardSquare(int xAxisLocation, int yAxisLocation, Color color)
            {
                XAxisLocation = xAxisLocation;
                YAxisLocation = yAxisLocation;
                Color = color;
            }
        }

    }
}
