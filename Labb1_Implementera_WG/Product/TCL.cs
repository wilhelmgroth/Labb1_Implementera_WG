using Labb1_Implementera_WG.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Product
{
    public class TCL : ITelevision
    {

        private static Remote _remoteInstance = null;


        public void ChangeBrightness()
        {
            Console.WriteLine("Changing Brightness");
        }

        public void ChangeContrast()
        {
            Console.WriteLine("Changing Contrast");
        }


        // Singleton design pattern
        // Enda instansen av en remote finns här
        public Remote GetRemoteSingleton()
        {
            if (_remoteInstance == null)
                _remoteInstance = new Remote();
            return _remoteInstance;
        }

        public void GetTime()
        {
            Console.WriteLine(DateTime.Now);
        }

    }
}
