using System;
using AutoPartsService.Users;
using AutoPartsService.Models;
using AutoPartsService.Logic;
using AutoPartsService.Logic.Factories;
using AutoPartsService.Logic.DeliveryStrategies;

namespace AutoPartsService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== СИСТЕМА ПІДБОРУ АВТОЗАПЧАСТИН ===\n");

            // Створення користувачів (Factory Method)
            Buyer buyer = (Buyer)UserFactory.CreateUser("buyer");
            buyer.Email = "driver@ua.net";
            buyer.Register();

            Supplier supplier = (Supplier)UserFactory.CreateUser("supplier");
            supplier.Email = "parts@shop.com";
            supplier.Register();

            Console.WriteLine("\n--- Постачальник наповнює склад ---");
            Part oilFilter = new Part { Name = "Масляний фільтр", Price = 450, Description = "Bosch Filter" };
            supplier.AddPart(oilFilter);

            Console.WriteLine("\n--- Покупець робить замовлення ---");
            // Створення замовлення (Observer підписка відбувається всередині методу)
            Order order = buyer.CreateOrder(oilFilter);

            // Вибір стратегії доставки (Strategy Pattern)
            order.SetDeliveryStrategy(new ExpressDelivery());

            // Розрахунок вартості
            order.CalculateTotal(oilFilter.Price);

            Console.WriteLine("\n--- Обробка замовлення ---");
            // Постачальник змінює статус -> Покупець автоматично отримує сповіщення
            supplier.ProcessOrder(order);

            Console.WriteLine();
            order.UpdateStatus("Відправлено");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}