// See https://aka.ms/new-console-template for more information
using System.Xml;
using zapuzdrenie_hodina_lib;

Console.WriteLine("Hello, World!");


Frog f1 = new("Pepe", 0.38, "Martin", new Tuple<double, double, double>(0.3, 1, 1), 4, false, true);
Frog f2 = new("Aquino", 0.35, "Marek", new Tuple<double, double, double>(7, 5, 2), 4, false, false);
Frog f3 = new("Palo", 0.5, "Anna", new Tuple<double, double, double>(2, 1, 1), 4, true, true);
Fish fi4 = new("Nemo", 0.08, "Martin", new Tuple<double, double, double>(5, 4, 3), true, false);
Fish fi5 = new("Alonso", 150, "Marcela", new Tuple<double, double, double>(15, 14, 6), true, true);
Fish fi6 = new("Seb", 0.28, "Peter", new Tuple<double, double, double>(2, 4, 3), false, false);

List<Animal> animals = new() { f1, f2, f3, fi4, fi5, fi6 };


Console.WriteLine(f1.ToString());

foreach (var animal in animals)
{
    Console.WriteLine(animal.ToString());
}

List<Frog> frogs = new() { f1, f2, f3};

foreach (var frog in frogs)
{
    Console.WriteLine(frog.ToString());
}

