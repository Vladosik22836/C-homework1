using System;

namespace ArrayCalcExample
{
    
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    class Array : ICalc
    {
        private int[] numbers;

        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;

            foreach (int num in numbers)
            {
                if (num < valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;

            foreach (int num in numbers)
            {
                if (num > valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 5, 10, 15, 20, 25, 30 };

            Array array = new Array(data);

            array.Show();

            int value = 18;

            Console.WriteLine($"\nComparison value: {value}");

            Console.WriteLine($"Number of elements less than {value}: {array.Less(value)}");

            Console.WriteLine( $"Number of elements greater than {value}: {array.Greater(value)}");
        }
    }
}