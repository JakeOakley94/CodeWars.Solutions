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

        [Test]
        public void DigitalCypher_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, DigitalCypher.Encode("scout", 1939));
            Assert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, DigitalCypher.Encode("masterpiece", 1939));
        }

    }
}
