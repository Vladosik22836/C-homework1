//Task 1
using System;
using System.Collections.Generic;
using System.Linq;

class Firm
{
    public string Name { get; set; }
    public DateTime Founded { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorFullName { get; set; }
    public int Employees { get; set; }
    public string Address { get; set; }

    public override string ToString()
    {
        return $"{Name}, {BusinessProfile}, Director: {DirectorFullName}, " +
               $"Employees: {Employees}, Address: {Address}, Founded: {Founded:d}";
    }
}

class Program
{
    static void Print(string title, IEnumerable<Firm> firms)
    {
        Console.WriteLine($"\n=== {title} ===");

        foreach (var firm in firms)
            Console.WriteLine(firm);
    }

    static void Main()
    {
        List<Firm> firms = new List<Firm>
        {
            new Firm
            {
                Name = "White Food Group",
                Founded = DateTime.Today.AddYears(-3),
                BusinessProfile = "Marketing",
                DirectorFullName = "John Black",
                Employees = 250,
                Address = "London"
            },

            new Firm
            {
                Name = "Tech Solutions",
                Founded = DateTime.Today.AddYears(-1),
                BusinessProfile = "IT",
                DirectorFullName = "Michael White",
                Employees = 500,
                Address = "New York"
            },

            new Firm
            {
                Name = "Food Market",
                Founded = DateTime.Today.AddDays(-123),
                BusinessProfile = "Marketing",
                DirectorFullName = "David Brown",
                Employees = 120,
                Address = "London"
            },

            new Firm
            {
                Name = "IT Future",
                Founded = DateTime.Today.AddYears(-5),
                BusinessProfile = "IT",
                DirectorFullName = "Sarah White",
                Employees = 90,
                Address = "Berlin"
            }
        };

        // 1
        Print("All companies", firms);

        // 2
        Print("The name contains Food",
            firms.Where(f => f.Name.Contains("Food")));

        // 3
        Print("Marketing industry",
            firms.Where(f => f.BusinessProfile == "Marketing"));

        // 4
        Print("Marketing or IT industry",
            firms.Where(f =>
                f.BusinessProfile == "Marketing" ||
                f.BusinessProfile == "IT"));

        // 5
        Print("More than 100 employees",
            firms.Where(f => f.Employees > 100));

        // 6
        Print("Employees from 100 to 300",
            firms.Where(f =>
                f.Employees >= 100 &&
                f.Employees <= 300));

        // 7
        Print("Located in London",
            firms.Where(f =>
                f.Address.Contains("London")));

        // 8
        Print("Director's last name White",
            firms.Where(f =>
                f.DirectorFullName.Split(' ').Last() == "White"));

        // 9
        Print("Founded more than two years ago",
            firms.Where(f =>
                f.Founded <= DateTime.Today.AddYears(-2)));

        // 10
        Print("Exactly 123 days have passed since the foundation",
            firms.Where(f =>
                (DateTime.Today - f.Founded.Date).Days == 123));

        // 11
        Print("Director Black and title contains White",
            firms.Where(f =>
                f.DirectorFullName.Split(' ').Last() == "Black" &&
                f.Name.Contains("White")));
    }
}