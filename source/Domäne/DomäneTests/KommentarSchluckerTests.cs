using rsloc.Domäne;
using NUnit.Framework;

namespace rsloc.Domäne.Tests
{
    using NUnit.Framework;

    using rsloc.contracts.daten;
    using rsloc.contracts.domäne;

    [TestFixture()]
    public class KommentarSchluckerTests
    {
        private Quellcode quellcode = new Quellcode();
        private KommentarSchlucker schlucker = new KommentarSchlucker();

        [Test()]
        public void Leerzeilen_schluckenTest()
        {
            string[] input = { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            string[] expexted = { "Eins", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.quellcode.Codezeilen = input;
            this.quellcode = this.schlucker.Leerzeilen_schlucken(this.quellcode);

            Assert.AreEqual(expexted, this.quellcode.Codezeilen);
        }

        [Test()]
        public void Mehrzeilige_Kommentare_schluckenTest()
        {
            string[] input = { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            string[] expexted = { "Eins", " ", "// Zwei", "Drei", "Sieben" };
            this.quellcode.Codezeilen = input;
            this.quellcode = this.schlucker.Mehrzeilige_Kommentare_schlucken(this.quellcode);

            Assert.AreEqual(expexted, this.quellcode.Codezeilen);
        }

        [Test()]
        public void Einzeilige_Kommentare_schluckenTest()
        {
            string[] input = { "Eins", " ", "// Zwei", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            string[] expexted = { "Eins", " ", "Drei", "/* Vier", "Fünf", "Sechs */", "Sieben" };
            this.quellcode.Codezeilen = input;
            this.quellcode = this.schlucker.Einzeilige_Kommentare_schlucken(this.quellcode);

            Assert.AreEqual(expexted, this.quellcode.Codezeilen);
        }

    }
}
