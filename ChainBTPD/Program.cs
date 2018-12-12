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
            int fangballkosten = 100;
            long chainlength = 128;

            // Print out welcome text
            foreach (var text in translation.welcome_text)
                Console.WriteLine(text);
            Console.WriteLine(translation.lets_go);

            Console.WriteLine(translation.which_pokemon);
            var Mon = Console.ReadLine();

            Console.WriteLine(translation.how_much_does);
            if (int.TryParse(Console.ReadLine(), out fangballkosten))
            { }
            else
            {
                fangballkosten = 100;
                Console.WriteLine(translation.autoset100);
            }

            Console.WriteLine(translation.how_long_are_you);

            if (long.TryParse(Console.ReadLine(), out chainlength))
            { }
            else
            {
                chainlength = 128;
                Console.WriteLine(translation.autoset128);
            }
            for (var i = 1; i <= chainlength; i++)
            {
                try
                {
                    Console.WriteLine($"{Mon} {i}/{chainlength}\n");
                    Console.Write(translation.how_much_candy);
                    if (long.TryParse(Console.ReadLine(), out np))
                    {
                        np2 = np * 10;
                        ChainBTPD = (ChainBTPD + np2) - fangballkosten;
                        Console.WriteLine(string.Format(translation.you_made, ChainBTPD));
                    }
                    else
                    {
                        Console.WriteLine(translation.errortext);
                        i--;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    continue;
                }
            }

            Console.ReadKey();
        }

        // Create translation from json file
        private static Translation setupTranslation()
        {
            Console.WriteLine("1: English (Englisch)");
            Console.WriteLine("2: German (Deutsch)");
            Console.Write("Language: ");

            string sel = Console.ReadLine();
            int selnum = 0;
            int.TryParse(sel, out selnum);

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