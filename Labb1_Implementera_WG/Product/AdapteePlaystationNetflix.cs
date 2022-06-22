using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Product
{

    // Adaptee. 
    // Contains some behaviour, but its interface is incompatible with the exisiting client code.
    // The Adaptee needs some adaption before the client code can run it. 
    public class AdapteePlaystationNetflix 
    {
        public void WatchingNetflixViaPS5()
        {
             Console.WriteLine("Watching Better Call Saul S4E3 on Netflix via Playstation 5");
        }
    }
}
