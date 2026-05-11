using System;

namespace WarehouseApp
{
    public class Product
    {
        private int _quantity;
        private decimal _price;

        public string Name { get; set; }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                _quantity = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product p, int amount)
        {
            p.Quantity += amount;
            return p;
        }

        public static Product operator -(Product p, int amount)
        {
            p.Quantity -= amount;
            return p;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2) => !(p1 == p2);

        public static bool operator >(Product p1, Product p2) => p1.Quantity > p2.Quantity;
        public static bool operator <(Product p1, Product p2) => p1.Quantity < p2.Quantity;

        public override bool Equals(object obj) => obj is Product p && this == p;
        public override int GetHashCode() => HashCode.Combine(Price);

        public override string ToString() => $"{Name}: {Quantity} pcs at ${Price}";
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Product p1 = new Product("Laptop", 5, 1200);
                Product p2 = new Product("Phone", 10, 1200);

                Console.WriteLine("--- Initial Products ---");
                Console.WriteLine(p1);
                Console.WriteLine(p2);

                p1 += 5;
                Console.WriteLine($"\nUpdated {p1.Name} quantity: {p1.Quantity}");

                Console.WriteLine($"Prices are equal: {p1 == p2}");
                Console.WriteLine($"{p2.Name} has more stock than {p1.Name}: {p2 > p1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}