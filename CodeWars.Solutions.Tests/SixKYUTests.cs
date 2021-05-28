using CodeWars.Solutions._6KYU.In_Progress;
using NUnit.Framework;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
    public class SixKYUTests
    {
        [Test]
        public void ChessFunChessBoardColor_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(true, ChessFunChessBoardColor.ChessBoardCellColor("A1", "C3"));
            Assert.AreEqual(false, ChessFunChessBoardColor.ChessBoardCellColor("A1", "H3"));
            Assert.AreEqual(false, ChessFunChessBoardColor.ChessBoardCellColor("A1", "A2"));
        }

        [Test] 
        public void PrizeDraw_WhenCalled_ProducesCorrectResult() 
        {
            string st = "";
            int[] we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("No participants", PrizeDraw.NthRank(st, we, 4));
            st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("Not enough participants", PrizeDraw.NthRank(st, we, 8));
            st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            we = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            Assert.AreEqual("Benjamin", PrizeDraw.NthRank(st, we, 4));
            st = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
            we = new int[] { 1, 3, 5, 5, 3, 6 };
            Assert.AreEqual("Matthew", PrizeDraw.NthRank(st, we, 2));
        }

        [Test]
        public void WhichAreIn_WhenCalled_ProducesCorrectResult()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }

    }
}
