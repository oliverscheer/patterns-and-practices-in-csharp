// See https://aka.ms/new-console-template for more information

using OliverScheer.Samples.PeriodicElementNameGenerator;

//Console.WriteLine("Hello, World!");

//Console.WriteLine("Enter your name: ");

//var name = Console.ReadLine();
var name = "Oliver";
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("You did not enter a name.");
    return;
}

var peng = new PeriodicElementNameGenerator();


peng.Process("Oliver");
peng.Process("Johanna");
peng.Process("Antonia");
peng.Process("Valentina");
peng.Process("Cosima");
