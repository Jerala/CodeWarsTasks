using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks
{
    [TestFixture]
    class LabyrinthPathFinderTest
    {
        [Test]
        static void sampleTests()
        {
            string a = ".W.\n" +
                  ".W.\n" +
                  "...",

              b = ".W.\n" +
                  ".W.\n" +
                  "W..",

              c = "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  "......",

              d = "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  ".....W\n" +
                  "....W.";

            Assert.AreEqual(true, LabyrinthPathFinder.PathFinder(a));
            Assert.AreEqual(false, LabyrinthPathFinder.PathFinder(b));
            Assert.AreEqual(true, LabyrinthPathFinder.PathFinder(c));
            Assert.AreEqual(false, LabyrinthPathFinder.PathFinder(d));
        }
    }
}
