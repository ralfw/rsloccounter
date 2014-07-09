
namespace rsloc.DomäneTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using rsloc.contracts.domäne;
    using rsloc.contracts.daten;
    using rsloc.Domäne;

    using NUnit.Framework;

    [TestFixture]
    public class StatistikTests
    {
        [Test]
        public void TestSummeLoc()
        {
            var quellcode = new Quellcode();
            string[] lines = { "Eins", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben", "" };
            quellcode.Codezeilen = lines;
            var testclass = new Statistik();
            testclass.LOC_summieren(quellcode);
            Assert.AreEqual(8, testclass.SummeLOC);
        }
    }
}
