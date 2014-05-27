
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
        private Quellcode quellcode;

        public StatistikTests()
        {
            string[] lines = { "Eins", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.quellcode.Codezeilen = lines;
        }

        [Test]
        public void TestSummeLoc()
        {
            var testclass = new Statistik();
            testclass.LOC_summieren(quellcode);
            Assert.AreEqual(7, testclass.SummeLOC);
        }
    }
}
