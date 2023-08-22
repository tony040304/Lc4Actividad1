using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lc4Ej1
{
    public interface IDelivery
    {
        void Retirar(string Ubicacion);
        void Entregar(string Ubicacion);
        void CalcularTiempo(int distanciaRetirar, int distanciaEntregar);
    }
}
