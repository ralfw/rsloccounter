using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using rswecker.provider;

namespace rswecker.tests
{
    [TestFixture]
    public class test_MP3
    {
        [Test]
        public void Play()
        {
            var sut = new MP3();
            sut.Abspielen();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
