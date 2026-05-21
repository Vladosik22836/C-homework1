using System;
using System.Collections.Generic;

//Task 1

class Program
{
    static void Main(string[] args)
    {
        Func<string, string> getRainbowColor = delegate (string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    return "RGB(255, 0, 0)";
                case "orange":
                    return "RGB(255, 165, 0)";
                case "yellow":
                    return "RGB(255, 255, 0)";
                case "green":
                    return "RGB(0, 255, 0)";
                case "blue":
                    return "RGB(0, 0, 255)";
                case "indigo":
                    return "RGB(75, 0, 130)";
                case "violet":
                    return "RGB(238, 130, 238)";
                default:
                    return "Unknown color";
            }
        };

        Console.WriteLine(getRainbowColor("red"));
        Console.WriteLine(getRainbowColor("green"));
        Console.WriteLine(getRainbowColor("blue"));
        Console.WriteLine(getRainbowColor("yellow"));
        Console.WriteLine(getRainbowColor("black")); 
    }
}

//Task 2
//namespace BackpackApp
//{
//    class Item
//    {
//        public string Name { get; set; }
//        public double Size { get; set; }

//        public Item(string name, double size)
//        {
//            Name = name;
//            Size = size;
//        }
//    }

//    class Backpack
//    {
//        public string Color { get; set; }
//        public string Brand { get; set; }
//        public string Fabric { get; set; }
//        public double Weight { get; set; }
//        public double Capacity { get; set; }

//        public List<Item> Content = new List<Item>();

//        public event Action<Item> ItemAdded;
//        public event Action<Item> ItemRemoved;
//        public event Action Changed;

//        public void AddItem(Item item)
//        {
//            double used = 0;

//            foreach (var i in Content)
//                used += i.Size;

//            if (used + item.Size > Capacity)
//                throw new Exception("Backpack is full!");

//            Content.Add(item);
//            ItemAdded?.Invoke(item);
//        }

//        public void RemoveItem(Item item)
//        {
//            Content.Remove(item);
//            ItemRemoved?.Invoke(item);
//        }

//        public void ChangeSettings(string color, string brand, string fabric, double weight, double capacity)
//        {
//            Color = color;
//            Brand = brand;
//            Fabric = fabric;
//            Weight = weight;

//            double used = 0;
//            foreach (var i in Content)
//                used += i.Size;

//            if (used > capacity)
//                throw new Exception("New capacity is too small!");

//            Capacity = capacity;
//            Changed?.Invoke();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Backpack backpack = new Backpack
//            {
//                Color = "Black",
//                Brand = "Nike",
//                Fabric = "Polyester",
//                Weight = 1.2,
//                Capacity = 10
//            };

//            backpack.ItemAdded += delegate (Item item)
//            {
//                Console.WriteLine("Added: " + item.Name);
//            };

//            backpack.ItemRemoved += delegate (Item item)
//            {
//                Console.WriteLine("Removed: " + item.Name);
//            };

//            backpack.Changed += delegate
//            {
//                Console.WriteLine("Backpack settings changed");
//            };

//            try
//            {
//                Item book = new Item("Book", 3);
//                Item laptop = new Item("Laptop", 5);

//                backpack.AddItem(book);
//                backpack.AddItem(laptop);

//                backpack.RemoveItem(book);

//                backpack.ChangeSettings("Blue", "Adidas", "Leather", 1.5, 8);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error: " + ex.Message);
//            }
//        }
//    }
//}

