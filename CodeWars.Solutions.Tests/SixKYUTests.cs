using CodeWars.Solutions._6KYU;
using NUnit.Framework;
using static CodeWars.Solutions._6KYU.TankTruckSolution;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
    public class SixKYUTests
    {
        [Test]
        public void BuyingACar_WhenCalled_ProducesCorrectResult()
        {
            int[] test1 = new int[] { 6, 766 };
            int[] test2 = new int[] { 0, 4000 };
            Assert.AreEqual(test1, BuyingACar.nbMonths(2000, 8000, 1000, 1.5));    
            Assert.AreEqual(test2, BuyingACar.nbMonths(12000, 8000, 1000, 1.5));
        }

        [Test]
        public void SortTheOdd_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, SortTheOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, SortTheOdd.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, SortTheOdd.SortArray(new int[] { }));
        }

        [Test]
        public void MultiplesOf3Or5_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(23, MultiplesOf3Or5.Solution(10));
        }

        [Test]
        public void ChessFunChessBoardColor_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(true, ChessFunChessBoardColor.ChessBoardCellColor("A1", "C3"));
            Assert.AreEqual(false, ChessFunChessBoardColor.ChessBoardCellColor("A1", "H3"));
            Assert.AreEqual(false, ChessFunChessBoardColor.ChessBoardCellColor("A1", "A2"));
        }

        [Test]
        public void SmallestPermutation_WhenCalled_ProducesCorrectResult()
        {
                Assert.AreEqual(-20, SmallestPermutation.MinPermutation(-20));
                Assert.AreEqual(-23, SmallestPermutation.MinPermutation(-32));
                Assert.AreEqual(0, SmallestPermutation.MinPermutation(0));
                Assert.AreEqual(10, SmallestPermutation.MinPermutation(10));
                Assert.AreEqual(23499, SmallestPermutation.MinPermutation(29394));
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

        [Test]
        public void TankTruck_WhenCalled_ProducesCorrectOutput()
        {
            Assert.AreEqual(2940, VolTank.TankVol(5, 7, 3848));
            Assert.AreEqual(907, VolTank.TankVol(2, 7, 3848));
        }

        [Test]
        public void ChessFunBishopAndPawn_WhenCalled_ProducesCorrectOutput()
        {
            Assert.AreEqual(true, ChessFunBishopAndPawn.BishopAndPawn("a1", "c3"));
            Assert.AreEqual(false, ChessFunBishopAndPawn.BishopAndPawn("h1", "h3"));
            Assert.AreEqual(true, ChessFunBishopAndPawn.BishopAndPawn("a5", "c3"));
            Assert.AreEqual(false, ChessFunBishopAndPawn.BishopAndPawn("g1", "f3"));
        }

    }
}
