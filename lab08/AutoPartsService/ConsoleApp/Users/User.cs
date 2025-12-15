using System;

namespace AutoPartsService.Users
{
    public abstract class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual void Register() => Console.WriteLine($"[User] {Role} зареєстрований: {Email}");
        public virtual void Login() => Console.WriteLine($"[User] {Role} ({Email}) увійшов у систему.");
        public virtual void EditProfile() => Console.WriteLine("[User] Профіль оновлено.");
        public virtual void DeleteAccount() => Console.WriteLine("[User] Акаунт видалено.");
    }
}