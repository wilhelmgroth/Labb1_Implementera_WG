using Labb1_Implementera_WG.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.ProductInterface
{
    public interface ITelevision
    {

        void GetTime();

        void ChangeBrightness();

        void ChangeContrast();

        Remote GetRemoteSingleton();
    }
}
