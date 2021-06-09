using CodeWars.Solutions._3KYU;
using NUnit.Framework;
using System;

namespace CodeWars.Solutions.Tests
{
    [TestFixture]
    public class ThreeKYUTests
    {
        [Test]
        public void LastDigitOfHugeNumber_WhenCalled_ProducesCorrectResult()
        {
            Random rnd = new Random();
            int rand1 = rnd.Next(0, 100);
            int rand2 = rnd.Next(0, 10);

            int[] test1 = new int[0];
            int[] test2 = new int[] { 0, 0 };
            int[] test3 = new int[] { 0, 0, 0 };
            int[] test4 = new int[] { 1, 2 };
            int[] test5 = new int[] { 3, 4, 5 };
            int[] test6 = new int[] { 4, 3, 6 };
            int[] test7 = new int[] { 7, 6, 21 };
            int[] test8 = new int[] { 12, 30, 21 };
            int[] test9 = new int[] { 2, 2, 2, 0 };
            int[] test10 = new int[] { 937640, 767456, 981242 };
            int[] test11 = new int[] { 123232, 694022, 140249 };
            int[] test12 = new int[] { 499942, 898102, 846073 };


            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test1), 1);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test2), 1);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test3), 0);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test4), 1);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test5), 1);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test6), 4);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test7), 1);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test8), 6);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test9), 4);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test10), 0);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test11), 6);
            Assert.AreEqual(LastDigitOfHugeNumber.LastDigit(test12), 6);
        }


    }
}
