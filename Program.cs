//using System;

//namespace ArrayCalcExample
//{

//    interface ICalc
//    {
//        int Less(int valueToCompare);
//        int Greater(int valueToCompare);
//    }

//    class Array : ICalc
//    {
//        private int[] numbers;

//        public Array(int[] numbers)
//        {
//            this.numbers = numbers;
//        }

//        public int Less(int valueToCompare)
//        {
//            int count = 0;

//            foreach (int num in numbers)
//            {
//                if (num < valueToCompare)
//                {
//                    count++;
//                }
//            }

//            return count;
//        }

//        public int Greater(int valueToCompare)
//        {
//            int count = 0;

//            foreach (int num in numbers)
//            {
//                if (num > valueToCompare)
//                {
//                    count++;
//                }
//            }

//            return count;
//        }

//        public void Show()
//        {
//            Console.WriteLine("Array elements:");

//            foreach (int num in numbers)
//            {
//                Console.Write(num + " ");
//            }

//            Console.WriteLine();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] data = { 5, 10, 15, 20, 25, 30 };

//            Array array = new Array(data);

//            array.Show();

//            int value = 18;

//            Console.WriteLine($"\nComparison value: {value}");

//            Console.WriteLine($"Number of elements less than {value}: {array.Less(value)}");

//            Console.WriteLine( $"Number of elements greater than {value}: {array.Greater(value)}");
//        }
//    }
//}
namespace RemoteControlExample
{
    // Interface
    interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }

    // TV class
    class TV : IRemoteControl
    {
        private bool isOn;
        private int currentChannel;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("TV is turned ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("TV is turned OFF");
        }

        public void SetChannel(int channel)
        {
            if (isOn)
            {
                currentChannel = channel;
                Console.WriteLine($"TV channel set to {currentChannel}");
            }
            else
            {
                Console.WriteLine("Turn on the TV first");
            }
        }
    }

    // Radio class
    class Radio : IRemoteControl
    {
        private bool isOn;
        private int currentChannel;

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Radio is turned ON");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Radio is turned OFF");
        }

        public void SetChannel(int channel)
        {
            if (isOn)
            {
                currentChannel = channel;
                Console.WriteLine($"Radio station set to {currentChannel}");
            }
            else
            {
                Console.WriteLine("Turn on the radio first");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();

            tv.TurnOn();
            tv.SetChannel(5);
            tv.TurnOff();

            Console.WriteLine();

            Radio radio = new Radio();

            radio.TurnOn();
            radio.SetChannel(101);
            radio.TurnOff();
        }
    }
}