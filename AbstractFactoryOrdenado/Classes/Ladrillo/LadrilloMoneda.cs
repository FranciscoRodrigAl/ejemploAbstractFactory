using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes.Ladrillo
{
    internal class LadrilloMoneda : ILadrillo
    {
        public string contieneItem()
        {
            return "Este ladrillo contiene una moneda de $10";
        }

        public string escondeBloqueInterrogacion(IBloqueInterrogacion bloque)
        {
            return " y además de la moneda aparece un bloque de interrogación: "+ bloque.nombreItemObtenido();
        }
    }
}
