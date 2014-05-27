using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using rsloc.contracts.adapter;
using rsloc.contracts.daten;

namespace rsloc.Provider
{
    public class CsProvider : ICsProvider
    {
        public void Quellcode_auslesen(string dateiname, Action<Quellcode> beiQuellcode)
        {
            var quellcode = new Quellcode();
            quellcode.Codezeilen = File.ReadAllLines(dateiname);
            beiQuellcode(quellcode);
        }
    }
}
