using Labb1_Implementera_WG.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Product
{
    public class Remote : IRemote
    {
        public void ChannelDown()
        {
            Console.WriteLine("Channel Down");
        }

        public void ChannelUp()
        {
            Console.WriteLine("Channel Up");
        }

        public void StartNetflix()
        {
            Console.WriteLine("Starting Netflix");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volume Down");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Volume Up");
        }
    }
}
