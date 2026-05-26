using System;

//Task 1

//namespace TheaterApp
//{
//    class Play : IDisposable
//    {
//        public string Title { get; set; }
//        public string AuthorFullName { get; set; }
//        public string Genre { get; set; }
//        public int Year { get; set; }

//        public Play(string title, string authorFullName, string genre, int year)
//        {
//            Title = title;
//            AuthorFullName = authorFullName;
//            Genre = genre;
//            Year = year;

//            Console.WriteLine($"[CREATE] Play '{Title}' has been created.");
//        }

//        public void ShowInfo()
//        {
//            Console.WriteLine("----- Play Information -----");
//            Console.WriteLine($"Title: {Title}");
//            Console.WriteLine($"Author: {AuthorFullName}");
//            Console.WriteLine($"Genre: {Genre}");
//            Console.WriteLine($"Year: {Year}");
//            Console.WriteLine("----------------------------");
//        }

//        ~Play()
//        {
//            Console.WriteLine($"[FINALIZER] Destructor called for '{Title}'.");
//        }

//        public void Dispose()
//        {
//            Console.WriteLine($"[DISPOSE] Object '{Title}' has been released.");
//            GC.SuppressFinalize(this);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (Play play1 = new Play("Hamlet", "William Shakespeare", "Tragedy", 1603))
//            {
//                play1.ShowInfo();
//            }

//            Play play2 = new Play("The Forest Song", "Lesya Ukrainka", "Drama-Fantasy", 1911);
//            play2.ShowInfo();
//            play2.Dispose();

//            CreateTestObject();

//            GC.Collect();
//            GC.WaitForPendingFinalizers();

//            Console.WriteLine("Program finished.");
//        }

//        static void CreateTestObject()
//        {
//            Play play3 = new Play("The Inspector General", "Nikolai Gogol", "Comedy", 1836);
//            play3.ShowInfo();
//        }
//    }
//}

//Task 2

namespace StoreApp
{
    enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Shoes
    }

    class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;

            Console.WriteLine($"[CREATE] Store '{Name}' created.");
        }

        public void ShowInfo()
        {
            Console.WriteLine("----- Store Information -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine("-----------------------------");
        }

        public void Dispose()
        {
            Console.WriteLine($"[DISPOSE] Store '{Name}' disposed.");
            GC.SuppressFinalize(this);
        }

        ~Store()
        {
            Console.WriteLine($"[FINALIZER] Destructor called for '{Name}'.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store(
                "ATB",
                "15 Central Street",
                StoreType.Grocery);

            store1.ShowInfo();

            store1.Dispose();

            Console.WriteLine();

            using (Store store2 = new Store(
                "Fashion Shop",
                "22 Main Avenue",
                StoreType.Clothing))
            {
                store2.ShowInfo();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program finished.");
        }
    }
}