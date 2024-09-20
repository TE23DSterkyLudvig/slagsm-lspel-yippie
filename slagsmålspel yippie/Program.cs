String name1 = "Ludde";
String name2 = "Felix";

int Hp1 = 100;
int Hp2 = 100;


Random generator = new Random();

System.Console.WriteLine(@$"{name1} och {name2} ska slåss.
Tryck på enter för att börja spelet");
var key = Console.ReadKey(true);
if (key.Key == ConsoleKey.Enter)
{
    while (Hp1 > 0 || Hp2 > 0)
    {
        int skada1 = Random.Shared.Next(5, 35);
        int skada2 = Random.Shared.Next(2, 40);
        //skada1 *= 1;
        //skada2 *= 1;

        Console.WriteLine($"{name1} slår {name2} och {name2} tar {skada2} i skada");
        Console.WriteLine($"{name2} slår {name1} och {name1} tar {skada1} i skada");
        Hp1 -= skada2;
        Hp2 -= skada1;

        Hp1 = Math.Max(0, Hp1);
        Hp2 = Math.Max(0, Hp2);

        Console.ReadLine();
    }
}

if (Hp2 <= 0)
{
    System.Console.WriteLine($" Ludde van med {Hp1} hälsa kvar ");
    System.Console.WriteLine("Tryck på S för att avsluta spelet");
    var stopp = Console.ReadKey(true);
    if (stopp.Key == ConsoleKey.S)
    {
        Environment.Exit(0);
    }
}

if (Hp1 <= 0)
{
    System.Console.WriteLine($" Felix van med {Hp2} hälsa kvar ");
    System.Console.WriteLine("Tryck på S för att avsluta spelet");
    var stopp = Console.ReadKey(true);
    if (stopp.Key == ConsoleKey.S)
    {
        Environment.Exit(0);
    }
}


Console.ReadLine();