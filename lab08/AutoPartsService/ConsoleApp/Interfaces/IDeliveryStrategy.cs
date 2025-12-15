using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsService.Interfaces
{
    public interface IDeliveryStrategy
    {
        double CalculateCost(double orderTotal);
        void Deliver();
    }
}
