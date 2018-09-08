using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTasks.CodeWarsTasksTests
{
    [TestFixture]
    class ParserTest
    {
        [Test]
        public void TestCase()
        {
            Assert.AreEqual(ParseInt_Reloader.Parser.parseInt("one"), 1);
            Assert.AreEqual(ParseInt_Reloader.Parser.parseInt("twenty"), 20);
            Assert.AreEqual(ParseInt_Reloader.Parser.parseInt("two hundred forty-six"), 246);
        }
    }
}
