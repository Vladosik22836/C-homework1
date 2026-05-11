using System;

namespace DeviceApp
{
    // Base class
    public abstract class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        protected Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public abstract void Sound();

        public void Show()
        {
            Console.WriteLine($"Device Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Characteristics}");
        }
    }

    // Derived class: Kettle
    public class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound() => Console.WriteLine("Sound: Ssss-Whistle!");
    }

    // Derived class: Microwave
    public class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound() => Console.WriteLine("Sound: Hummm... Beeep!");
    }

    // Derived class: Car
    public class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound() => Console.WriteLine("Sound: Vroom Vroom!");
    }

    // Derived class: Steamboat
    public class Steamboat : Device
    {
        public Steamboat(string name, string characteristics) : base(name, characteristics) { }

        public override void Sound() => Console.WriteLine("Sound: Tooooot-Tooooot!");
    }

    class Program
    {
        static void Main()
        {
            // Creating instances
            Device[] devices = new Device[]
            {
                new Kettle("Electric Kettle", "1.7L, 2200W, Stainless Steel"),
                new Microwave("Samsung Smart", "800W, 23L, Ceramic Inside"),
                new Car("Tesla Model 3", "Electric, Autopilot, Dual Motor"),
                new Steamboat("Titanic II", "Steam engine, Luxury interior")
            };

            // Displaying information for each device
            foreach (var device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}