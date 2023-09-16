using AbstractFactoryOrdenado.Classes.BloqueInterrogacion;
using AbstractFactoryOrdenado.Classes.Ladrillo;
using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes.Factories
{
    internal class FabricaPremios : IMarioWorldFactory
    {
        public IBloqueInterrogacion CreateBloqueInterrogacion()
        {
            return new BloqueInterrogacionEstrella();
        }

        public ILadrillo CreateBloqueLadrillo()
        {
            return new LadrilloMoneda();
        }
    }
}
