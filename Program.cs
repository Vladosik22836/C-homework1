using System;
using System.Collections;
using System.Collections.Generic;

//Task 1

// Базовий клас 
//class SeaCreature
//{
//    public string Name { get; set; }
//    public string Species { get; set; }

//    public SeaCreature(string name, string species)
//    {
//        Name = name;
//        Species = species;
//    }

//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($"{Species}: {Name}");
//    }
//}

//class Fish : SeaCreature
//{
//    public Fish(string name)
//        : base(name, "Fish") { }
//}

//class Shark : SeaCreature
//{
//    public Shark(string name)
//        : base(name, "Shark") { }
//}

//class Dolphin : SeaCreature
//{
//    public Dolphin(string name)
//        : base(name, "Dolphin") { }
//}

//class Oceanarium : IEnumerable<SeaCreature>
//{
//    private List<SeaCreature> creatures = new List<SeaCreature>();

//    public void AddCreature(SeaCreature creature)
//    {
//        creatures.Add(creature);
//    }

//    public IEnumerator<SeaCreature> GetEnumerator()
//    {
//        foreach (var creature in creatures)
//        {
//            yield return creature;
//        }
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Oceanarium oceanarium = new Oceanarium();

//        oceanarium.AddCreature(new Fish("Nemo"));
//        oceanarium.AddCreature(new Shark("Bruce"));
//        oceanarium.AddCreature(new Dolphin("Flipper"));

//        Console.WriteLine("Aquarium inhabitants: ");

//        foreach (var creature in oceanarium)
//        {
//            creature.ShowInfo();
//        }
//    }
//}

//Task 2

// Клас Гравець
class Player
{
    public string Name { get; set; }
    public int Number { get; set; }
    public string Position { get; set; }

    public Player(string name, int number, string position)
    {
        Name = name;
        Number = number;
        Position = position;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"№{Number} {Name} - {Position}");
    }
}

class FootballTeam : IEnumerable<Player>
{
    private List<Player> players = new List<Player>();

    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public IEnumerator<Player> GetEnumerator()
    {
        foreach (var player in players)
        {
            yield return player;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        FootballTeam team = new FootballTeam();

        team.AddPlayer(new Player("Messi", 10, "Forward"));
        team.AddPlayer(new Player("Ronaldo", 7, "Forward"));
        team.AddPlayer(new Player("Neuer", 1, "Goalkeeper"));

        Console.WriteLine("Football team composition:");

        foreach (var player in team)
        {
            player.ShowInfo();
        }
    }
}


        