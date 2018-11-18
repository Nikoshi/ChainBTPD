using System;

namespace ChainBTPD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please choose your language.(1=English)");
            Console.WriteLine("Bitte wähle deine Sprache.(2=Deutsch)");
            Console.Write("Language:");
            string sel = Console.ReadLine();
            int selnum = int.Parse(sel);
            switch (selnum)
            {
                case 1:
                    Console.WriteLine("Welcome to the ChainBTPD ProfitCalculator!");
                    Console.WriteLine("If you chain Pokemon you can get Berries and Candy");
                    Console.WriteLine("You can sell these things! You get 10P$ for a Candy and 100P$ for a Berry!");
                    Console.WriteLine("With that money you can buy new Pokeballs!");
                    Console.WriteLine("At the start your Profit is going to be in the negatives but give it some time!");
                    Console.WriteLine("Lets Go!");
                    Console.WriteLine("Which Pokemon are you chaining?");
                    var Mon = Console.ReadLine();
                    long ChainBTPD = 0;
                    long np;
                    long np2;
                    Console.WriteLine("How much does you Catchball cost? (100=Pokeball, 300=Greatball, 500=Ultraball)");
                    int fangballkosten;
                    fangballkosten = int.Parse(Console.ReadLine());
                    Console.WriteLine("How long are you going to chain?");
                    long chainlength;
                    chainlength = long.Parse(Console.ReadLine());
                    for (var i = 1; i <= chainlength; i++)
                    {
                        Console.WriteLine(Mon + " " + i);
                        Console.WriteLine();
                        Console.Write("How much Candy (1 Berry = 10 Candy, one throw without catch means minus!(-10=Pokeball, -30=Greatball, -50=all)) did you get for this Pokemon?");
                        np = long.Parse(Console.ReadLine());
                        np2 = np * 10;
                        ChainBTPD = (ChainBTPD + np2) - fangballkosten;
                        Console.WriteLine("You made " + ChainBTPD + " Poke$ Profit");



                    }
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Wilkommen im ChainBTPD ProfitRechner!");
                    Console.WriteLine("Wenn du Pokemon chainst bekommst du Beeren und Bonbons");
                    Console.WriteLine("Diese Dinge kannst du verkaufen! Du bekommst 10 P$ für ein Candy und 100 für eine Beere!");
                    Console.WriteLine("So kannst du für die Kosten des Pokeballs aufkommen!");
                    Console.WriteLine("Am Anfang wirst du Minus machen aber gib der Methode etwas Zeit!");
                    Console.WriteLine("Lets Go!");
                    Console.WriteLine("Welches Pokemon chainst du?");
                    var Mong = Console.ReadLine();
                    long ChainBTPDg = 0;
                    long npg;
                    long np2g;
                    Console.WriteLine("Wieviel kostet dein Fangball? (100=Pokeball, 300=Superball, 500=Hyperball)");
                    int fangballkosteng;
                    fangballkosteng = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wie lang wirst du chainen?");
                    long chainlengthg;
                    chainlengthg = long.Parse(Console.ReadLine());
                    for (var i = 1; i <= chainlengthg; i++)
                    {
                        Console.WriteLine(Mong + " " + i);
                        Console.WriteLine();
                        Console.Write("Wie viel Candy (1 Beere = 10 Candy, einmal danebenwerfen bedeutet du musst Bonbons abziehen!(-10=Pokeball, -30=Superball, -50=Hyperball)) hast du bekommen?");
                        npg = long.Parse(Console.ReadLine());
                        np2g = npg * 10;
                        ChainBTPDg = (ChainBTPDg + np2g) - fangballkosteng;
                        Console.WriteLine("Du hast " + ChainBTPDg + " Poke$ Profit gemacht");



                    }
                    Console.ReadKey();
                    break;
            }

        }
    }
}
