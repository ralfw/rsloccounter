using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rsloc.contracts;

namespace rsloc.application
{
    class Program
    {
        static void Main(string[] args)
        {
            var di = new SimpleInjector.Container();
            var app = di.GetInstance<IApplication>();
            app.Run();
        }
    }
}
