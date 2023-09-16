using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes.BloqueInterrogacion
{
    internal class BloqueInterrogacionTrampa : IBloqueInterrogacion
    {
        public string nombreItemObtenido()
        {
            return "obtiene un hongo venenoso";
        }

    }
}
