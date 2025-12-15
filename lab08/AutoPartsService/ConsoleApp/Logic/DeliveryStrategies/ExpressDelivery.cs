using System;
using AutoPartsService.Interfaces;

namespace AutoPartsService.Logic.DeliveryStrategies
{
    public class ExpressDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double orderTotal) => 150.0;
        public void Deliver() => Console.WriteLine("--- Доставка: Експрес-кур'єр виїхав. ---");
    }
}