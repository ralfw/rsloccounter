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
        public void Weckzeit_erreicht()
        {
            var sut = new Weckauftrag("12:58", true, () => new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 57, 0));
            var result = false;
            sut.Weckzeit_erreicht(() => result = true);
            Assert.IsFalse(result);

            sut = new Weckauftrag("12:57", true, () => new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 57, 0));
            result = false;
            sut.Weckzeit_erreicht(() => result = true);
            Assert.IsTrue(result);

            sut = new Weckauftrag("12:56", true, () => new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 57, 0));
            sut.Weckzeit_erreicht(() => result = true);
            Assert.IsTrue(result);
        }

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
