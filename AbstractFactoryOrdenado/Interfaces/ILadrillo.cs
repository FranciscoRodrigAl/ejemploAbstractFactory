using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Interfaces
{
    internal interface ILadrillo
    {
        string contieneItem();

        string escondeBloqueInterrogacion(IBloqueInterrogacion bloque);
    }
}
