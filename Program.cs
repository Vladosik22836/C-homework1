using System;

class Program
{
    static void Main()
    {
        ////Task 1

        //Console.Write("Enter the side size: ");
        //int size = int.Parse(Console.ReadLine() ?? "5");

        //char symbol;

        //while (true)
        //{
        //    Console.Write("Enter the symbol: ");
        //    string input = Console.ReadLine() ?? "";

        //    if (input.Length == 1)
        //    {
        //        symbol = input[0];
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error .");
        //    }
        //}

        //Console.WriteLine();
        //DrawSquare(size, symbol);

        //Task 4

        //Console.WriteLine(" Input from the console ");
        //Website site1 = new Website();
        //site1.Input();

        //Console.WriteLine("\n Site data 1 ");
        //site1.Print();

        //Website site2 = new Website(
        //    "GitHub",
        //    "https://github.com",
        //    "Developer platform",
        //    "140.82.121.4"
        //);

        //Console.WriteLine("\n Site data 2 ");
        //site2.Print();

        //site2.SetName("GitHub (updated)");
        //site2.SetIpAddress("192.30.255.112");

        //Console.WriteLine("\n After updating fields ");
        //Console.WriteLine($"Name: {site2.GetName()}");
        //Console.WriteLine($"IP:    {site2.GetIpAddress()}");

        //Task 5

        Console.WriteLine("=== Input from console ===");
        Journal j1 = new Journal();
        j1.Input();

        Console.WriteLine("\n--- Journal 1 ---");
        j1.Print();

        // 2 — via constructor
        Journal j2 = new Journal(
            "National Geographic",
            1888,
            "Science and nature magazine",
            "+1-800-647-5463",
            "contact@natgeo.com"
        );

        Console.WriteLine("\n--- Journal 2 ---");
        j2.Print();

        // 3 — via setters
        j2.SetName("National Geographic (UA)");
        j2.SetPhone("+380-44-000-0000");

        Console.WriteLine("\n--- After update ---");
        Console.WriteLine($"Name:  {j2.GetName()}");
        Console.WriteLine($"Phone: {j2.GetPhone()}");
    }

    //Task 1

    //static void DrawSquare(int size, char symbol)
    //{
    //    for (int i = 0; i < size; i++)
    //    {
    //        for (int j = 0; j < size; j++)
    //        {
    //            Console.Write(symbol);
    //        }

    //        Console.WriteLine();
    //    }
    //}
}

//Task 4

//class Website
//{
//    private string name;
//    private string url;
//    private string description;
//    private string ipAddress;

//    public Website() { }

//    public Website(string name, string url, string description, string ipAddress)
//    {
//        this.name = name;
//        this.url = url;
//        this.description = description;
//        this.ipAddress = ipAddress;
//    }

//    public string GetName() => name;
//    public string GetUrl() => url;
//    public string GetDescription() => description;
//    public string GetIpAddress() => ipAddress;

//    public void SetName(string value) => name = value;
//    public void SetUrl(string value) => url = value;
//    public void SetDescription(string value) => description = value;
//    public void SetIpAddress(string value) => ipAddress = value;

//    public void Input()
//    {
//        Console.Write("Site name:  ");
//        name = Console.ReadLine() ?? "";

//        Console.Write("URL:          ");
//        url = Console.ReadLine() ?? "";

//        Console.Write("Description:         ");
//        description = Console.ReadLine() ?? "";

//        Console.Write("IP address:    ");
//        ipAddress = Console.ReadLine() ?? "";
//    }

//    public void Print()
//    {
//        Console.WriteLine($"  Name:    {name}");
//        Console.WriteLine($"  URL:      {url}");
//        Console.WriteLine($"  Description:     {description}");
//        Console.WriteLine($"  IP:       {ipAddress}");
//    }
//}

//Task 5

class Journal
{
    private string name;
    private int foundedYear;
    private string description;
    private string phone;
    private string email;

    public Journal() { }

    public Journal(string name, int foundedYear, string description, string phone, string email)
    {
        this.name = name;
        this.foundedYear = foundedYear;
        this.description = description;
        this.phone = phone;
        this.email = email;
    }

    public string GetName() => name;
    public int GetFoundedYear() => foundedYear;
    public string GetDescription() => description;
    public string GetPhone() => phone;
    public string GetEmail() => email;

    public void SetName(string value) => name = value;
    public void SetFoundedYear(int value) => foundedYear = value;
    public void SetDescription(string value) => description = value;
    public void SetPhone(string value) => phone = value;
    public void SetEmail(string value) => email = value;

    public void Input()
    {
        Console.Write("Magazine name:   ");
        name = Console.ReadLine() ?? "";

        Console.Write("Year of foundation:  ");
        foundedYear = int.Parse(Console.ReadLine() ?? "2000");

        Console.Write("Description:            ");
        description = Console.ReadLine() ?? "";

        Console.Write("Phone:         ");
        phone = Console.ReadLine() ?? "";

        Console.Write("Email:           ");
        email = Console.ReadLine() ?? "";
    }

    public void Print()
    {
        Console.WriteLine($"  name:               {name}");
        Console.WriteLine($"  Year of foundation: {foundedYear}");
        Console.WriteLine($"  Description:        {description}");
        Console.WriteLine($"  Phone:              {phone}");
        Console.WriteLine($"  Email:              {email}");
    }
}