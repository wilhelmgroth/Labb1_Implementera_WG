using Labb1_Implementera_WG.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Product
{

    // This Adapter class makes the Adaptee's interface compatible with the target's interface
    public class AdapterPlaystationNetflix : IPlaystation
    {
        private readonly AdapteePlaystationNetflix _playstationNetflix;

        public AdapterPlaystationNetflix(AdapteePlaystationNetflix playstationNetflix)
        {
            _playstationNetflix = playstationNetflix;  
        }

        public void WatchNetflix()
        {
            // A bunch of other stuff...
            _playstationNetflix.WatchingNetflixViaPS5();
           
        }
    }
}
