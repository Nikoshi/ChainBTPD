using System;

namespace ChainBTPD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen im ChainBTPD ProfitRechner!");
            Console.WriteLine("Wenn du Pokemon chainst bekommst du Beeren und Bonbons");
            Console.WriteLine("Diese Dinge kannst du verkaufen! Du bekommst 10 P$ für ein Candy und 100 für eine Beere!");
            Console.WriteLine("So kannst du für die Kosten des Pokeballs aufkommen!");
            Console.WriteLine("Lets Go!");
            Console.WriteLine("Welches Pokemon chainst du?");
            var Mon = Console.ReadLine();
            long ChainBTPD = 0;
            long np;
            long np2;
            Console.WriteLine("Wieviel kostet dein Fangball? (100=Pokeball, 300=Superball, 500=Hyperball)");
            int fangballkosten;
            fangballkosten = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie lang wirst du chainen?");
            long chainlength;
            chainlength = long.Parse(Console.ReadLine());
            for (var i = 1; i <= chainlength; i++)
            {
                Console.WriteLine(Mon + " " + i);
                Console.WriteLine("Wie viel Candy (1 Beere = 10 Candy, einmal danebenwerfen bedeutet du musst Bonbons abziehen!(-10=Pokeball, -30=Superball, -50=Hyperball)) hast du bekommen?");
                np = long.Parse(Console.ReadLine());
                np2 = np * 10;
                ChainBTPD = (ChainBTPD + np2) - fangballkosten;
                Console.WriteLine("Du hast " + ChainBTPD + " Poke$ Profit gemacht");



            }
            Console.ReadKey();
        }
    }
}
