using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes.BloqueInterrogacion
{
    internal class BloqueInterrogacionEstrella : IBloqueInterrogacion
    {
        public string nombreItemObtenido()
        {
            return "obtiene una estrella de poder";
        }
    }
}
