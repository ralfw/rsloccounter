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
                _weckzeit = this.NowToTheSecond().Add(TimeSpan.Parse(zeitwert));
        }


        public TimeSpan VerbleibendeZeit { get { return _weckzeit.Subtract(_now()); } }


        public void Weckzeit_erreicht(Action beiErreicht)
        {            
            var verbleibendeSekunden = (int)_weckzeit.Subtract(this.NowToTheSecond()).TotalSeconds;
            Console.WriteLine("{0}, {1}, {2}", _weckzeit, this.NowToTheSecond(), verbleibendeSekunden);
            if (verbleibendeSekunden == 0)
                beiErreicht();
        }


        private DateTime NowToTheSecond()
        {
            return  new DateTime(_now().Year, _now().Month, _now().Day, _now().Hour, _now().Minute, _now().Second);
        }
    }
}
