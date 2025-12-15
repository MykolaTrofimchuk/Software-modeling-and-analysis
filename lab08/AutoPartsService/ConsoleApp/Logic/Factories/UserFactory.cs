using System;
using AutoPartsService.Users;

namespace AutoPartsService.Logic.Factories
{
    public class UserFactory
    {
        public static User CreateUser(string role)
        {
            switch (role.ToLower())
            {
                case "buyer": return new Buyer();
                case "admin": return new Admin();
                case "supplier": return new Supplier();
                default: throw new ArgumentException("Невідома роль користувача");
            }
        }
    }
}