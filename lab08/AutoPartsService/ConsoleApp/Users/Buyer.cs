using System;
using System.Collections.Generic;
using AutoPartsService.Interfaces;
using AutoPartsService.Models;
using AutoPartsService.Logic;

namespace AutoPartsService.Users
{
    public class Buyer : User, IObserver
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Review> Reviews { get; set; } = new List<Review>();

        public Buyer() { Role = "Buyer"; }

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
            Console.WriteLine($"[Buyer] Авто {vehicle.Model} додано до профілю.");
        }

        public void SearchParts() => Console.WriteLine("[Buyer] Пошук запчастин...");

        public Order CreateOrder(Part part)
        {
            var order = new Order();
            // Підписуємося на оновлення статусу
            order.AddObserver(this);
            Orders.Add(order);
            Console.WriteLine("[Buyer] Створено нове замовлення.");
            return order;
        }

        // Реалізація інтерфейсу IObserver
        public void Update(string message)
        {
            Console.WriteLine($" >>> [Сповіщення для {Email}]: {message}");
        }
    }
}