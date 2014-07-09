using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rswecker
{
    class Weckauftrag
    {
        private readonly Func<DateTime> _now;
        private DateTime _weckzeit;

        public Weckauftrag(string zeitwert, bool zeitwertIstWeckzeit) : this(zeitwert, zeitwertIstWeckzeit, () => DateTime.Now ){}
        public Weckauftrag(string zeitwert, bool zeitwertIstWeckzeit, Func<DateTime> now)
        {
            _now = now;
            if (zeitwertIstWeckzeit)
                _weckzeit = DateTime.Parse(zeitwert);
            else
                _weckzeit = this._now().Add(TimeSpan.Parse(zeitwert));
        }

        public TimeSpan VerbleibendeZeit { get { return _weckzeit.Subtract(_now()); } }
    }
}
