using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MagazineSerialization
{
    // Task 2
    public class Article
    {
        public string Title { get; set; }
        public int CharacterCount { get; set; }
        public string Preview { get; set; }
    }

    public class Magazine
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Pages { get; set; }

        public List<Article> Articles { get; set; } = new List<Article>();
    }

    class Program
    {
        static void Main()
        {
            Magazine magazine = null;
            string fileName = "magazine.json";

            while (true)
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Enter magazine information");
                Console.WriteLine("2. Display magazine information");
                Console.WriteLine("3. Save magazine to file");
                Console.WriteLine("4. Load magazine from file");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================");

                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        magazine = InputMagazine();
                        break;

                    case "2":
                        DisplayMagazine(magazine);
                        break;

                    case "3":
                        SaveMagazine(magazine, fileName);
                        break;

                    case "4":
                        magazine = LoadMagazine(fileName);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static Magazine InputMagazine()
        {
            Magazine magazine = new Magazine();

            Console.Write("Magazine title: ");
            magazine.Title = Console.ReadLine();

            Console.Write("Publisher: ");
            magazine.Publisher = Console.ReadLine();

            Console.Write("Release date (yyyy-mm-dd): ");
            magazine.ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Number of pages: ");
            magazine.Pages = int.Parse(Console.ReadLine());

            Console.Write("How many articles does the magazine contain? ");
            int articleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articleCount; i++)
            {
                Console.WriteLine($"\n--- Article #{i + 1} ---");

                Article article = new Article();

                Console.Write("Article title: ");
                article.Title = Console.ReadLine();

                Console.Write("Character count: ");
                article.CharacterCount = int.Parse(Console.ReadLine());

                Console.Write("Article preview: ");
                article.Preview = Console.ReadLine();

                magazine.Articles.Add(article);
            }

            return magazine;
        }

        static void DisplayMagazine(Magazine magazine)
        {
            if (magazine == null)
            {
                Console.WriteLine("No data available.");
                return;
            }

            Console.WriteLine("\n========== MAGAZINE ==========");
            Console.WriteLine($"Title: {magazine.Title}");
            Console.WriteLine($"Publisher: {magazine.Publisher}");
            Console.WriteLine($"Release Date: {magazine.ReleaseDate:dd.MM.yyyy}");
            Console.WriteLine($"Pages: {magazine.Pages}");

            Console.WriteLine("\nArticles:");

            if (magazine.Articles.Count == 0)
            {
                Console.WriteLine("No articles available.");
            }
            else
            {
                for (int i = 0; i < magazine.Articles.Count; i++)
                {
                    Console.WriteLine($"\nArticle #{i + 1}");
                    Console.WriteLine($"Title: {magazine.Articles[i].Title}");
                    Console.WriteLine($"Character Count: {magazine.Articles[i].CharacterCount}");
                    Console.WriteLine($"Preview: {magazine.Articles[i].Preview}");
                }
            }

            Console.WriteLine("==============================");
        }

        static void SaveMagazine(Magazine magazine, string fileName)
        {
            if (magazine == null)
            {
                Console.WriteLine("No data to save.");
                return;
            }

            string json = JsonSerializer.Serialize(
                magazine,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(fileName, json);

            Console.WriteLine("Magazine successfully saved.");
        }

        static Magazine LoadMagazine(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return null;
            }

            string json = File.ReadAllText(fileName);

            Magazine magazine =
                JsonSerializer.Deserialize<Magazine>(json);

            Console.WriteLine("Magazine successfully loaded.");

            return magazine;
        }
    }
}