using System;
using System.Linq;

class Program
{
    static void Main()
    {
        ////Task 1

        //int[,] matrix = new int[5, 5];
        //Random rnd = new Random();

        //Console.WriteLine("Massif:");
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        matrix[i, j] = rnd.Next(-100, 101);
        //        Console.Write($"{matrix[i, j],5}");
        //    }
        //    Console.WriteLine();
        //}

        //int minVal = matrix[0, 0], maxVal = matrix[0, 0];
        //int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (matrix[i, j] < minVal)
        //        {
        //            minVal = matrix[i, j];
        //            minRow = i; minCol = j;
        //        }
        //        if (matrix[i, j] > maxVal)
        //        {
        //            maxVal = matrix[i, j];
        //            maxRow = i; maxCol = j;
        //        }
        //    }
        //}

        //int minIndex = minRow * 5 + minCol;
        //int maxIndex = maxRow * 5 + maxCol;

        //int left = Math.Min(minIndex, maxIndex);
        //int right = Math.Max(minIndex, maxIndex);

        //long sum = 0;
        //for (int k = left + 1; k < right; k++)
        //{
        //    int row = k / 5;
        //    int col = k % 5;
        //    sum += matrix[row, col];
        //}

        //Console.WriteLine($"\nMini: {minVal} on position [{minRow},{minCol}]");
        //Console.WriteLine($"Max: {maxVal} on position [{maxRow},{maxCol}]");

        //if (right - left <= 1)
        //    Console.WriteLine("\nThere are no elements between the min and max..");
        //else
        //    Console.WriteLine($"\nSum of elements between min and max: {sum}");

        ////Task 2

        Console.Write("Enter the text: ");
        string text = Console.ReadLine() ?? "";

        Console.Write("Enter the offset (1-25): ");
        int shift = int.Parse(Console.ReadLine() ?? "3") % 26;

        string encrypted = CaesarCipher.Encrypt(text, shift);
        string decrypted = CaesarCipher.Decrypt(encrypted, shift);

        Console.WriteLine($"\nOriginal:  {text}");
        Console.WriteLine($"Encrypted: {encrypted}");
        Console.WriteLine($"Decrypted: {decrypted}");
    }
}

class CaesarCipher
{
    static char CaesarChar(char c, int shift)
    {
        if (!char.IsLetter(c)) return c;
        char baseChar = char.IsUpper(c) ? 'A' : 'a';
        return (char)(baseChar + (c - baseChar + shift) % 26);
    }

    public static string Encrypt(string text, int shift) =>
        new string(text.Select(c => CaesarChar(c, shift)).ToArray());

    public static string Decrypt(string text, int shift) =>
        Encrypt(text, 26 - shift);
}
