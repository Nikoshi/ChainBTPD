using Newtonsoft.Json;
using System;

namespace ChainBTPD
{
    /// <summary>
    /// Data Model for translations
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// Welcome to the ChainBTPD [...]
        /// </summary>      
        public string[] welcome_text { get; set; }

        /// <summary>
        /// Lets Go!
        /// </summary>       
        public string lets_go { get; set; }

        /// <summary>
        /// Which Pokemon are you chaining?
        /// </summary>       
        public string which_pokemon { get; set; }

        /// <summary>
        /// How much does you Catchball cost?
        /// </summary>      
        public string how_much_does { get; set; }

        /// <summary>
        /// How long are you going to chain?
        /// </summary>   
        public string how_long_are_you { get; set; }

        /// <summary>
        /// How much Candy did you get for this Pokemon?
        /// </summary>
        public string how_much_candy { get; set; }

        /// <summary>
        /// You made `profit` Poke$ Profit
        /// </summary>
        public string you_made { get; set; }

        public static Translation LoadFromJson(string jsonFileName)
        {
            try
            {
                var fileContent = System.IO.File.ReadAllText(jsonFileName);
                var translation = JsonConvert.DeserializeObject<Translation>(fileContent);

                return translation;
            }
            catch (System.Exception ex)
            {
                Console.Error.WriteLine($"Loading translation failed: {ex.Message}");
                throw;
            }
        }
    }
}