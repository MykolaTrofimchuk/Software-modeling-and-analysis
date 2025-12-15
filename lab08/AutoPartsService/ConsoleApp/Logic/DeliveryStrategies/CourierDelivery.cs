using System;
using AutoPartsService.Interfaces;

namespace AutoPartsService.Logic.DeliveryStrategies
{
    public class CourierDelivery : IDeliveryStrategy
    {
        public double CalculateCost(double orderTotal) => 100.0;
        public void Deliver() => Console.WriteLine("--- Доставка: Кур'єр отримав замовлення. ---");
    }
}