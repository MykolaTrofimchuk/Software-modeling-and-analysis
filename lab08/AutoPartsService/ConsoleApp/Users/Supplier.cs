using System;
using AutoPartsService.Models;
using AutoPartsService.Logic;

namespace AutoPartsService.Users
{
    public class Supplier : User
    {
        public Inventory MyInventory { get; set; } = new Inventory();

        public Supplier() { Role = "Supplier"; }

        public void ManageInventory() => Console.WriteLine("[Supplier] Перевірка складу...");
        public void AddPart(Part part) => MyInventory.AddPart(part);
        public void DeletePart(Part part) => MyInventory.RemovePart(part);

        public void ProcessOrder(Order order)
        {
            Console.WriteLine("[Supplier] Обробка нового замовлення...");
            order.UpdateStatus("Оброблено (Ready to ship)");
        }
    }
}