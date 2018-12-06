using Newtonsoft.Json;

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
        public string[] welcome_text {get;}
        
        /// <summary>
        /// Lets Go!
        /// </summary>       
        public string lets_go {get;}

        /// <summary>
        /// Which Pokemon are you chaining?
        /// </summary>       
        public string which_pokemon {get;}
        
        /// <summary>
        /// How much does you Catchball cost?
        /// </summary>      
        public string how_much_does {get;}

        /// <summary>
        /// How long are you going to chain?
        /// </summary>   
        public string how_long_are_you {get;}

        /// <summary>
        /// How much Candy did you get for this Pokemon?
        /// </summary>
        public string how_much_candy {get;}

        /// <summary>
        /// You made `profit` Poke$ Profit
        /// </summary>
        public string you_made {get;}

        public static Translation LoadFromJson(string jsonFileName)
        {
            var fileContent = System.IO.File.ReadAllText(jsonFileName);
            var translation = JsonConvert.DeserializeObject<Translation>(fileContent);

            return new Translation();    
        }
    }
}