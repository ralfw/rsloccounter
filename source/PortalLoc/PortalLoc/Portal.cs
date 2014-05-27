using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rsloc.contracts.adapter;

namespace PortalLoc
{
    public class Portal : IPortal
    {
        public void LOC_ausgeben(int loc)
        {
            Console.WriteLine("LOC: {0}", loc);
        }

        public string Quellenangabe_bestimmen()
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length <= 1)
            {
                throw new ArgumentException("No command line arguments!");
            }

            return args[1];
        }
    }
}
