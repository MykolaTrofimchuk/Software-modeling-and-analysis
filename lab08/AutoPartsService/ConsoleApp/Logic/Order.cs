using System;
using System.Collections.Generic;
using AutoPartsService.Interfaces;

namespace AutoPartsService.Logic
{
    public class Order : ISubject
    {
        public string Status { get; private set; }
        public double TotalPrice { get; private set; }

        private IDeliveryStrategy _deliveryStrategy;
        private List<IObserver> _observers = new List<IObserver>();

        public void SetDeliveryStrategy(IDeliveryStrategy strategy)
        {
            _deliveryStrategy = strategy;
            Console.WriteLine($"[Order] Обрано стратегію доставки: {strategy.GetType().Name}");
        }

        public void CalculateTotal(double partsPrice)
        {
            if (_deliveryStrategy == null)
            {
                Console.WriteLine("[Order] Помилка: Спосіб доставки не обрано!");
                return;
            }
            double deliveryCost = _deliveryStrategy.CalculateCost(partsPrice);
            TotalPrice = partsPrice + deliveryCost;
            Console.WriteLine($"[Order] Розрахунок: Товар ({partsPrice}) + Доставка ({deliveryCost}) = {TotalPrice}");
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"[Order] Статус змінено на: {Status}");
            NotifyObservers(); // Сповіщаємо покупця
        }

        // --- ISubject Implementation ---
        public void AddObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update($"Ваше замовлення перейшло у статус: {Status}");
            }
        }
    }
}