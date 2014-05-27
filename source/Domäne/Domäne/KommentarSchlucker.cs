namespace rsloc.Domäne
{
    using System.Collections.Generic;

    using rsloc.contracts.daten;
    using rsloc.contracts.domäne;

    public class KommentarSchlucker: IKommentarschlucker
    {
        public Quellcode Einzeilige_Kommentare_schlucken(Quellcode quellcode)
        {
            var puffer = new List<string>();

            foreach (var codeZeile in quellcode.Codezeilen)
            {
                var zeile = codeZeile.TrimStart(' ');
                if (!zeile.StartsWith("//"))
                {
                    puffer.Add(codeZeile);
                }
            }

            quellcode.Codezeilen = puffer.ToArray();
            return quellcode;
        }

        public Quellcode Leerzeilen_schlucken(Quellcode quellcode)
        {
            var puffer = new List<string>();

            foreach (var codeZeile in quellcode.Codezeilen)
            {
                var zeile = codeZeile.Trim(' ');
                if (!string.IsNullOrEmpty(zeile))
                {
                    puffer.Add(codeZeile);
                }
            }

            quellcode.Codezeilen = puffer.ToArray();
            return quellcode;
        }

        public Quellcode Mehrzeilige_Kommentare_schlucken(Quellcode quellcode)
        {
            return quellcode;
        }
    }
}
