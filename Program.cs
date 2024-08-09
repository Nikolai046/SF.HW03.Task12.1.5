using System;
using System.Collections.Generic;
using System.Threading;

namespace SF.HW03.Task12._1._5;
class Program
{
    static void Main(string[] args)
    {
        List<User> users =
        [
            new User() { Login = "user1", Name = "Иван", IsPremium = false },
            new User() { Login = "user2", Name = "Мария", IsPremium = true },
            new User() { Login = "user3", Name = "Алексей", IsPremium = false }
        ];

        foreach (var user in users)
        {
            Console.WriteLine($"Здравствуйте, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }

            Console.WriteLine();
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}
