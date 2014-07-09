using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalLoc;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Portal portal = new Portal();
            var quelle = portal.Quellenangabe_bestimmen();

            Console.WriteLine(quelle);

            portal.LOC_ausgeben(5);
            Console.ReadLine();
        }
    }
}
