using AbstractFactoryOrdenado.Classes.Factories;
using AbstractFactoryOrdenado.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryOrdenado.Classes
{
    internal class Cliente
    {

        public void Main()
        {
            Console.WriteLine("Cliente: Quiero pedir bloques malos...");
            ClienteSolicita(new FabricaMala());

            Console.WriteLine("Cliente: Ahora quiero pedir bloques de premios...");
            ClienteSolicita(new FabricaPremios());
        }

        public void ClienteSolicita(IMarioWorldFactory fabrica)
        {
            var ladrillo = fabrica.CreateBloqueLadrillo();
            var bloqueInterrogacion = fabrica.CreateBloqueInterrogacion();

            Console.WriteLine("\nEntregando ladrillo y bloque de interrogación de la fábrica...");
            Console.Write(ladrillo.contieneItem());
            Console.WriteLine(ladrillo.escondeBloqueInterrogacion(bloqueInterrogacion));
        }
    }
}
