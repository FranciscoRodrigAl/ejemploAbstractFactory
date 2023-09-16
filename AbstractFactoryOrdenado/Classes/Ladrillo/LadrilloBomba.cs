using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes.Ladrillo
{
    internal class LadrilloBomba : ILadrillo
    {
        public string contieneItem()
        {
            return "Este ladrillo tiene una bomba dentro";
        }

        public string escondeBloqueInterrogacion(IBloqueInterrogacion bloque)
        {
            return ", y junto con la bomba aparece un bloque de interrogación:"+ bloque.nombreItemObtenido();
        }
    }
}
