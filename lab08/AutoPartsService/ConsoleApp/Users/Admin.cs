using System;

namespace AutoPartsService.Users
{
    public class Admin : User
    {
        public Admin() { Role = "Admin"; }

        public void ModerateContent() => Console.WriteLine("[Admin] Модерація контенту...");
        public void ManageUsers() => Console.WriteLine("[Admin] Управління користувачами...");
        public void GenerateReports() => Console.WriteLine("[Admin] Звіт згенеровано.");
    }
}