using System;
using AutoPartsService.Interfaces;

namespace AutoPartsService.Logic.DeliveryStrategies
{
    public class PickupDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double orderTotal) => 0;
        public void Deliver() => Console.WriteLine("--- Доставка: Самовивіз оформлено. ---");
    }
}