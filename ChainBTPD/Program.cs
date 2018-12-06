using System;
using System.Collections.Generic;

namespace ChainBTPD
{
    class Program
    {
        static void Main(string[] args)
        {        
            // Setup translation
            Translation translation = setupTranslation();

            long ChainBTPD = 0;
            long np;
            long np2;
            int fangballkosten;
            long chainlength;
            
            // Print out welcome text
            foreach (string text in translation.welcome_text)
                Console.WriteLine(text);
            Console.WriteLine(translation.lets_go);

            Console.WriteLine(translation.which_pokemon);
            var Mon = Console.ReadLine();
            
            Console.WriteLine(translation.how_much_does);
            fangballkosten = int.Parse(Console.ReadLine());
            Console.WriteLine(translation.how_long_are_you);
            
            chainlength = long.Parse(Console.ReadLine());
            for (var i = 1; i <= chainlength; i++)
            {
                Console.WriteLine($"{Mon} {i}\n");
                Console.Write(translation.how_much_candy);
                np = long.Parse(Console.ReadLine());
                np2 = np * 10;
                ChainBTPD = (ChainBTPD + np2) - fangballkosten;
                Console.WriteLine(string.Format(translation.you_made, ChainBTPD));
            }

            Console.ReadKey();
        }

        // Create translation from json file
        private Translation setupTranslation()
        {
            Console.WriteLine("1: English (Englisch)");
            Console.WriteLine("2: German (Deutsch)");
            Console.Write("Language: ");
            
            string sel = Console.ReadLine();
            int selnum = int.Parse(sel);

            string languageFile = String.Empty;
            switch (selnum)
            {
                case 1:
                    languageFile = "en-us.json";
                    break;
                case 2:
                    languageFile = "de-de.json";
                    break;
                default:
                    languageFile = "en-us.json";
                    break;
            }

            return Translation.LoadFromJson(languageFile);
        }
    }
}
