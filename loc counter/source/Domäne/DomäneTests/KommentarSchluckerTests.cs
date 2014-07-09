using rsloc.Domäne;
using NUnit.Framework;

namespace rsloc.Domäne.Tests
{
    using NUnit.Framework;

    using rsloc.contracts.daten;

    [TestFixture()]
    public class KommentarSchluckerTests
    {
        private Quellcode quellcode = new Quellcode();
        private Quellcode expectedResult = new Quellcode();
        private KommentarSchlucker schlucker = new KommentarSchlucker();

        [Test()]
        public void Leerzeilen_schluckenTest()
        {
            this.quellcode.Codezeilen = new[] { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.expectedResult.Codezeilen = new[] { "Eins", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };

            Assert.AreEqual(this.expectedResult.Codezeilen, this.schlucker.Leerzeilen_schlucken(this.quellcode).Codezeilen);
        }

        [Test()]
        public void Mehrzeilige_Kommentare_schluckenTest()
        {
            this.quellcode.Codezeilen = new[] { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.expectedResult.Codezeilen = new[] { "Eins", " ", "// Zwei", "Drei", "Sieben" };

            Assert.AreEqual(this.expectedResult.Codezeilen, this.schlucker.Mehrzeilige_Kommentare_schlucken(this.quellcode).Codezeilen);
        }

        [Test()]
        public void Einzeilige_Kommentare_schluckenTest()
        {
            this.quellcode.Codezeilen = new[] { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.expectedResult.Codezeilen = new[] { "Eins", " ", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };

            Assert.AreEqual(this.expectedResult.Codezeilen, this.schlucker.Einzeilige_Kommentare_schlucken(this.quellcode).Codezeilen);
        }

    }
}
