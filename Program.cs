using System;
using System.IO;

//Task 1

//namespace NumberGeneratorApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();

//            int[] numbers = new int[100];

//            string primeFile = "moldova.txt"; // це звичайні числа, просто назвати їх original було б скучно :)
//            string fibonacciFile = "fibonacci.txt";

//            using (StreamWriter primeWriter = new StreamWriter(primeFile))
//            using (StreamWriter fibonacciWriter = new StreamWriter(fibonacciFile))
//            {
//                for (int i = 0; i < 100; i++)
//                {
//                    numbers[i] = random.Next(1, 101);

//                    if (IsPrime(numbers[i]))
//                    {
//                        primeWriter.WriteLine(numbers[i]);
//                    }

//                    if (IsFibonacci(numbers[i]))
//                    {
//                        fibonacciWriter.WriteLine(numbers[i]);
//                    }
//                }
//            }

//            Console.WriteLine("===== Application Statistics =====");
//            Console.WriteLine($"Generated numbers: {numbers.Length}");
//            Console.WriteLine($"Prime numbers saved to: {primeFile}");
//            Console.WriteLine($"Fibonacci numbers saved to: {fibonacciFile}");

//            Console.WriteLine("\n===== Original List of Numbers =====");

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.Write(numbers[i] + " ");
//            }

//            Console.WriteLine("\n\nProgram finished.");
//        }

//        static bool IsPrime(int number)
//        {
//            if (number < 2)
//                return false;

//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                    return false;
//            }

//            return true;
//        }

//        static bool IsFibonacci(int number)
//        {
//            int a = 0;
//            int b = 1;

//            while (a <= number)
//            {
//                if (a == number)
//                    return true;

//                int temp = a + b;
//                a = b;
//                b = temp;
//            }

//            return false;
//        }
//    }
//}

//Task 2

namespace TextReplacementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "text.txt";

            Console.Write("Enter the word to search: ");
            string searchWord = Console.ReadLine();

            Console.Write("Enter the replacement word: ");
            string replaceWord = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string text = File.ReadAllText(filePath);

            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(searchWord, index)) != -1)
            {
                count++;
                index += searchWord.Length;
            }

            text = text.Replace(searchWord, replaceWord);

            File.WriteAllText(filePath, text);

            Console.WriteLine("\n===== Application Statistics =====");
            Console.WriteLine($"Search word: {searchWord}");
            Console.WriteLine($"Replacement word: {replaceWord}");
            Console.WriteLine($"Replacements made: {count}");
            Console.WriteLine($"Processed file: {filePath}");
            Console.WriteLine("Program finished.");
        }
    }
}