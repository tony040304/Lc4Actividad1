using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lc4Ej1
{
    public class Repartidor : IDelivery
    {
        public void Retirar(string Ubicacion)
        {
            Console.WriteLine("El repartidor debe ir a buscar su pedido a " + Ubicacion);
        }
        public void Entregar(string Ubicacion)
        {
            Console.WriteLine("El repartidor debe llevar el pedido a " + Ubicacion);
        }
        public void CalcularTiempo(int distanciaRetirar, int distanciaEntregar)
        {
            double distancia = (distanciaRetirar + distanciaEntregar) * 0.60;
            Console.WriteLine("El Repartidor va a tardar " + distancia + " minutos");
        }
    }
}
