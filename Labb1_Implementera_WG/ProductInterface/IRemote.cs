using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.ProductInterface
{
    public interface IRemote
    {
        void VolumeUp();
        void VolumeDown();
        void ChannelUp();
        void ChannelDown();
        void StartNetflix();
    }
}
