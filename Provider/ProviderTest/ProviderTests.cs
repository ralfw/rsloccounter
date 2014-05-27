using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using rsloc.Provider;
using rsloc.contracts.daten;

namespace rsloc.ProviderTest
{
    [TestClass]
    public class ProviderTests
    {
        [TestMethod]
        public void CsProviderTest()
        {
            var csProvider = new CsProvider();
            Quellcode quellcode = null;
            csProvider.Quellcode_auslesen("TextFile1.txt", q => quellcode = q);

            Assert.IsNotNull(quellcode);
            Assert.AreEqual(quellcode.Codezeilen.Length, 3);
        }

        [TestMethod]
        public void FolderProviderTest()
        {
            var folderProvider = new FolderProvider();
            var files = new HashSet<string>();
            folderProvider.Ermittle_Dateinamen(".", f => files.Add(System.IO.Path.GetFileName(f)));

            Assert.AreEqual(files.Count, 2);
            Assert.IsTrue(files.Contains("CodeFile1.cs"));
            Assert.IsTrue(files.Contains("CodeFile2.cs"));
        }
    }
}
