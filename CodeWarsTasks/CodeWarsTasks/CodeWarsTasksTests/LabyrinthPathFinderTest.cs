using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeWarsTasks.CodeWarsTasksTests
{
    [TestFixture]
    class LabyrinthPathFinderTest
    {
        [Test]
        public static void sampleTests()
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