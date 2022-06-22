using Labb1_Implementera_WG.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Product
{
    public class Samsung : ITelevision
    {
        private static Remote _remoteInstance = null;
        public void ChangeBrightness()
        {
            Console.WriteLine("Changing brightness");
        }

        public void ChangeContrast()
        {
            Console.WriteLine("Changing contrast");
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
            var date =  DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine(date);
            
        }
    }
}
