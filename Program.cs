class Homework
{
    static void Main()
    {
        ////Task 1
        Console.Write("Enter number (1-100): ");

        string input = Console.ReadLine();

        if (!int.TryParse(input, out int num))
        {
            Console.WriteLine("Error, an integer is required");
            return;
        }

        if (num < 1 || num > 100)
        {
            Console.WriteLine("Error, 1 and 100!");
            return;
        }

        if (num % 3 == 0 && num % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (num % 3 == 0)
            Console.WriteLine("Fizz");
        else if (num % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(num);

        ////Task 2

        //Console.Write("Enter the number: ");
        //double num = double.Parse(Console.ReadLine());

        //Console.Write("Enter a percentage of a number: ");
        //double percent = double.Parse(Console.ReadLine());

        //if (num < 1 || num > 100 || percent < 1 || percent > 100)
        //{
        //    Console.WriteLine("Error, invalid!!!!!!!!");
        //    return; 
        //}

        //double result = num * percent / 100;

        //Console.WriteLine("Result -> " + result); // дуже не привичний синаксиз, я замість "+" ставив "," та думав чого не працює :) 


        //Task 3 з цим завданням дуже довго грався, але зробив всі захисти від користувача

        //Console.Write("Enter 4 numbers: ");
        //string[] parts = Console.ReadLine().Split(' ');

        //if (parts.Length != 4)
        //{
        //    Console.WriteLine("Error, 4 digits are required.");
        //    return;
        //}

        //if (!int.TryParse(parts[0], out int a) ||
        //    !int.TryParse(parts[1], out int b) ||
        //    !int.TryParse(parts[2], out int c) ||
        //    !int.TryParse(parts[3], out int d))
        //{
        //    Console.WriteLine("Error, an integer is required.");
        //    return;
        //}

        //if (a < 0 || a > 9 || b < 0 || b > 9 || c < 0 || c > 9 || d < 0 || d > 9)
        //{
        //    Console.WriteLine("Error, 0 to 9!");
        //    return;
        //}

        //int number = a * 1000 + b * 100 + c * 10 + d;

        //Console.WriteLine("Result number: " + number);
    }
}
