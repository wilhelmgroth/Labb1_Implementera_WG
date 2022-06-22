using Labb1_Implementera_WG.Product;
using Labb1_Implementera_WG.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera_WG.Factory
{
    public static class TelevisionFactory
    {
        // Implementering av Factory Method
        // Instansierar klasserna TCL/Samsung


        public static ITelevision GetTelevision(ModelType modelType) => (modelType) switch
        {
            ModelType.TCL => new TCL(),
            ModelType.Samsung => new Samsung(),
            _ => throw new NotImplementedException()
        };


    }
}
