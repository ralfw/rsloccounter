using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalLoc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PortalLoc.Tests
{
    [TestClass()]
    public class PortalTests
    {
        [TestMethod()]
        public void Quellenangabe_bestimmenTest()
        {
            Portal portal = new Portal();
            
            var quelle = portal.Quellenangabe_bestimmen();
            Assert.Equals(quelle, "");
        }
    }
}
