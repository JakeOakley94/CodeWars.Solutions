using CodeWars.Solutions._7KYU.In_Progress;
using NUnit.Framework;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
   public class SevenKYUTests
    {

        [Test]
        public void ChessFunKnight_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(2, ChessFunKnight.ChessKnight("a1"));
            Assert.AreEqual(6, ChessFunKnight.ChessKnight("c2"));
            Assert.AreEqual(8, ChessFunKnight.ChessKnight("d4"));
            Assert.AreEqual(6, ChessFunKnight.ChessKnight("g6"));
        }

    }
}
