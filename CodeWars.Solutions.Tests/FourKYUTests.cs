using CodeWars.Solutions._4KYU;
using NUnit.Framework;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
    public class FourKYUTests
    {
        [Test]
        public void IntParseReloaded_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual(22, IntParserReloaded.ParseInt("twenty-two"));
            Assert.AreEqual(1, IntParserReloaded.ParseInt("one"));
            Assert.AreEqual(20, IntParserReloaded.ParseInt("twenty"));
            Assert.AreEqual(246, IntParserReloaded.ParseInt("two hundred forty-six"));
        }


    }
}
