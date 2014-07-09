using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rsloc.contracts;
using rsloc.contracts.adapter;

namespace Integration
{
    public class Application : IApplication
    {
        private IPortal portal;
        private IInteractors interactor;

        public Application(IPortal portal, IInteractors interactor)
        {
            this.portal = portal;
            this.interactor = interactor;
        }
        
        #region IApplication Members

        public void Run()
        {
            string quelle = this.portal.Quellenangabe_bestimmen();
            int loc = this.interactor.LOC_zählen(quelle);
            portal.LOC_ausgeben(loc);
        }

        #endregion
    }
}
