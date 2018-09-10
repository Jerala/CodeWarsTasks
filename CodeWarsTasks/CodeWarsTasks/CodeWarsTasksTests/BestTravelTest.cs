using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace CodeWarsTasks.CodeWarsTasksTests
{
    [TestFixture]
    class BestTravelTest
    {
        [Test]
        public void TestCase()
        {
            List<Int32> ts = new List<Int32>(new Int32[] { 50, 55, 56, 57, 58 });
            int n = BestTravel.BestTravel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(163, n);
            ts = new List<Int32>(new Int32[] { 50 });
            Int32 m = BestTravel.BestTravel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(-1, m);
            ts = new List<Int32>(new Int32[] { 91, 74, 73, 85, 73, 81, 87 });
            n = BestTravel.BestTravel.chooseBestSum(230, 3, ts);
            Assert.AreEqual(228, n);
        }
    }
}