using System;

namespace AutoPartsService.Models
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VIN { get; set; }

        public void EditDetails(string make, string model)
        {
            Make = make;
            Model = model;
            Console.WriteLine($"[Vehicle] Дані авто {VIN} оновлено.");
        }
    }
}