using System;
using System.Collections.Generic;

namespace AutoPartsService.Models
{
    public class Part
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Compatibility { get; set; } = new List<string>();

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            Console.WriteLine($"[Part] Ціна на {Name} оновлена до {Price}");
        }

        public void AddCompatibility(string vehicleModel)
        {
            Compatibility.Add(vehicleModel);
        }
    }
}