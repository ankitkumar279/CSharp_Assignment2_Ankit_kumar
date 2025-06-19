using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Assignment2_API_AK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Question3_4 : ControllerBase
    {
        /// <summary>
        /// This method adds up the spiciness of peppers in a chili.
        /// You give a list of pepper names separated by commas.
        /// It returns the total spiciness as a number.
        /// </summary>
        /// <param name="Ingredients">Comma separated list of pepper names (like "Poblano,Cayenne")</param>
        /// <returns>Total spiciness in SHU (Scoville Heat Units)</returns>
        /// <example>
        /// GET /api/Question3_4/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai
        /// Returns: 116500
        /// </example>
        [HttpGet("ChiliPeppers")]
        public IActionResult ChiliPeppers(string Ingredients)
        {
            var peppers = new Dictionary<string, int>()
            {
                {"Poblano", 1500},
                {"Mirasol", 6000},
                {"Serrano", 15500},
                {"Cayenne", 40000},
                {"Thai", 75000},
                {"Habanero", 125000}
            };

            if (string.IsNullOrEmpty(Ingredients))
                return Ok(0);

            int total = 0;
            string[] items = Ingredients.Split(',');

            foreach (var item in items)
            {
                string pepper = item.Trim();
                if (peppers.ContainsKey(pepper))
                {
                    total += peppers[pepper];
                }
            }

            return Ok(total);
        }

        /// <summary>
        /// This method counts how many words in a sentence start with a vowel.
        /// It checks the sentence you send and returns the number of words starting with a, e, i, o, or u.
        /// </summary>
        /// <param name="sentence">The sentence to check.</param>
        /// <returns>Number of words that start with a vowel.</returns>
        /// <example>
        /// GET /api/Question3_4/VowelWords?sentence=Apple is awesome and orange
        /// Returns: 5
        /// </example>
        [HttpGet("VowelWords")]
        public IActionResult VowelWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return Ok(0);

            string[] words = sentence.Split(' ');
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word) && vowels.Contains(word[0]))
                    count++;
            }

            return Ok(count);
        }
    }
}
