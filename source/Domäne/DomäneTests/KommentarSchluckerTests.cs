﻿namespace rsloc.Domäne.Tests
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
    }
}
