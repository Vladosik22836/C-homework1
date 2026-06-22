using System;
using System.Collections.Generic;
using Serilog;

namespace FakeUserGeneratorApp
{
    // ================================
    // USER MODEL
    // ================================
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    // ================================
    // FAKE USER GENERATOR CLASS
    // ================================
    public class FakeUserGenerator
    {
        private Random _random = new Random();

        private string[] firstNames = { "John", "Alex", "Michael", "David", "Chris", "Anna", "Maria", "Olivia" };
        private string[] lastNames = { "Smith", "Brown", "Johnson", "Williams", "Taylor", "Davis", "Wilson" };
        private string[] cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro" };

        public User GenerateUser()
        {
            var first = firstNames[_random.Next(firstNames.Length)];
            var last = lastNames[_random.Next(lastNames.Length)];

            var user = new User
            {
                FirstName = first,
                LastName = last,
                Phone = GeneratePhone(),
                Email = $"{first.ToLower()}.{last.ToLower()}@mail.com",
                Address = $"{cities[_random.Next(cities.Length)]}, Ukraine"
            };

            return user;
        }

        private string GeneratePhone()
        {
            return $"+380{_random.Next(100000000, 999999999)}";
        }
    }

    // ================================
    // PROGRAM (TESTING)
    // ================================
    class Program
    {
        static void Main()
        {
            // ================================
            // SERILOG CONFIGURATION
            // ================================
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Application started");

            var generator = new FakeUserGenerator();
            var users = new List<User>();

            Console.Write("How many fake users to generate? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var user = generator.GenerateUser();
                users.Add(user);

                Log.Information("Generated user: {First} {Last}, {Email}",
                    user.FirstName, user.LastName, user.Email);
            }

            Console.WriteLine("\n=== GENERATED USERS ===");

            foreach (var user in users)
            {
                Console.WriteLine($"\nName: {user.FirstName} {user.LastName}");
                Console.WriteLine($"Phone: {user.Phone}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Address: {user.Address}");
            }

            Log.Information("Application finished");
            Log.CloseAndFlush();
        }
    }
}