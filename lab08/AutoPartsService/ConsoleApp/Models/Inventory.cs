using System;
using System.Collections.Generic;

namespace AutoPartsService.Models
{
    public class Inventory
    {
        public List<Part> Parts { get; set; } = new List<Part>();

        public void AddPart(Part part)
        {
            Parts.Add(part);
            Console.WriteLine($"[Inventory] Запчастину {part.Name} додано до інвентарю.");
        }

        public void RemovePart(Part part)
        {
            Parts.Remove(part);
            Console.WriteLine($"[Inventory] Запчастину {part.Name} видалено з інвентарю.");
        }

        public void UpdateStock(Part part, int quantity)
        {
            Console.WriteLine($"[Inventory] Кількість {part.Name} оновлено: {quantity} шт.");
        }
    }
}