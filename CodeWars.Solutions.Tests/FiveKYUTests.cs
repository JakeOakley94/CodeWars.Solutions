using CodeWars.Solutions._5KYU.In_Progress;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
    public class FiveKYUTests
    {
        [Test]
        public void One800CodeWars_WhenCalled_ProducesCorrectResult()
        {
            var expected = new HashSet<string> { "1-800-CODE-WAR", "1-800-CODE-YAP", "1-800-CODE-WAS", "1-800-CODE-ZAP" };
            var outputSet = One800CodeWars.Check1800("1-800-CODE-WAR");
            var result = expected.SetEquals(outputSet);
            Assert.IsTrue(result);
        }

        [Test]
        public void ROT13_WhenCalled_ProducesCorrectResult()
        {
            Assert.AreEqual("ROT13 example.", ROT13.Rot13("EBG13 rknzcyr."));
        }
    }
}
