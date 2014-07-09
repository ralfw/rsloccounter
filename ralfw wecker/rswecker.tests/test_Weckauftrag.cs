using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace rswecker.tests
{
    [TestFixture]
    public class test_Weckauftrag
    {
        [Test]
        public void VerbleibendeZeit()
        {
            var sut = new Weckauftrag("12:58", true, () => new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 57, 0));
            Assert.AreEqual(TimeSpan.FromSeconds(60), sut.VerbleibendeZeit);
        }

        [Test]
        public void Initialisieren_mit_Ruhezeit()
        {
            var sut = new Weckauftrag("00:01:00", false, () => new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 57, 0));
            Assert.AreEqual(TimeSpan.FromSeconds(60), sut.VerbleibendeZeit);
        }
    }
}
