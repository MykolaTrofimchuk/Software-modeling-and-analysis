using System;
using AutoPartsService.Interfaces;

namespace AutoPartsService.Logic.DeliveryStrategies
{
    public class PostalDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double orderTotal) => 50.0;
        public void Deliver() => Console.WriteLine("--- Доставка: Відправлено поштою. ---");
    }
}