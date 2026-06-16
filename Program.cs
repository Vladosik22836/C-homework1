//Task 1

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] a = { "Ukraine", "Poland", "Germany", "France" };
//        string[] b = { "Germany", "Italy", "France", "Spain" };

//        // 1. Різниця A \ B
//        var difference = a.Where(x => !b.Contains(x)).ToArray();

//        // 2. Перетин
//        var intersection = a.Where(x => b.Contains(x)).ToArray();

//        // 3. Об'єднання без дублікатів
//        var union = a.Union(b).ToArray();

//        // 4. Перший масив без повторень
//        var uniqueA = a.Distinct().ToArray();

//        Console.WriteLine("Difference (A \\ B): " + string.Join(", ", difference));
//        Console.WriteLine("Intersection: " + string.Join(", ", intersection));
//        Console.WriteLine("Union: " + string.Join(", ", union));
//        Console.WriteLine("Unique A: " + string.Join(", ", uniqueA));
//    }
//}

//Task 2

using System;
using System.Collections.Generic;
using System.Linq;

class Device
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }

    public Device(string name, string manufacturer, double price)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} | {Manufacturer} | {Price}";
    }
}

class Program
{
    static void Main()
    {
        List<Device> a = new List<Device>
        {
            new Device("Phone A", "Apple", 1000),
            new Device("Phone B", "Samsung", 800),
            new Device("Tablet A", "Lenovo", 500),
        };

        List<Device> b = new List<Device>
        {
            new Device("Phone C", "Samsung", 900),
            new Device("Laptop A", "HP", 1200),
            new Device("Tablet B", "Apple", 700),
        };

        // 1. Різниця (A \ B) — виробники, яких нема в B
        var diff = a.Where(x => !b.Any(y => y.Manufacturer == x.Manufacturer));

        // 2. Перетин — спільні виробники
        var intersection = a.Where(x => b.Any(y => y.Manufacturer == x.Manufacturer));

        // 3. Об'єднання без дублікатів (по виробнику)
        var union = a.Concat(b)
                     .GroupBy(x => x.Manufacturer)
                     .Select(g => g.First());

        Console.WriteLine("DIFFERENCE:");
        foreach (var d in diff) Console.WriteLine(d);

        Console.WriteLine("\nINTERSECTION:");
        foreach (var d in intersection) Console.WriteLine(d);

        Console.WriteLine("\nUNION:");
        foreach (var d in union) Console.WriteLine(d);
    }
}