using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lc4Ej1
{
    public class ConcreteDeliveryFactory : DeliveryFactory
    {
        public override IDelivery GetDelivery(string TipeOfDelivery)
        {
            switch (TipeOfDelivery)
            {
                case "Repartidor":
                    return new Repartidor();
                case "Dron repartidor":
                    return new DronRepartidor();
                default:
                    throw new ApplicationException(string.Format($"Delivery {TipeOfDelivery} cannot be created"));
            }
        }
    }
}
