using Microsoft.AspNetCore.Mvc;

namespace Assignment2_API_AK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Question1_2 : ControllerBase
    {
        /// <summary>
        /// This method calculates the final score in the Deliv-e-droid game.
        /// It uses how many packages were delivered and how many times the droid hit obstacles.
        /// </summary>
        /// <param name="Collisions">The number of times the droid hit an obstacle.</param>
        /// <param name="Deliveries">The number of packages successfully delivered.</param>
        /// <returns>The final score as a number.</returns>
        /// <example>
        /// POST /api/Question1_2/Delivedroid
        /// Body: Collisions=2&Deliveries=5
        /// Returns: 730
        /// </example>
        [HttpPost("Delivedroid")]
        public IActionResult Delivedroid([FromForm] int Collisions, [FromForm] int Deliveries)
        {
            int score = Deliveries * 50 - Collisions * 10;
            if (Deliveries > Collisions)
            {
                score += 500;
            }
            return Ok(score);
        }

        /// <summary>
        /// This method calculates the total calories of a hamburger meal.
        /// You give it numbers for burger, drink, side, and dessert choices.
        /// It adds up calories for each choice and returns the total.
        /// </summary>
        /// <param name="burger">Burger choice number (1 to 3)</param>
        /// <param name="drink">Drink choice number (1 to 3)</param>
        /// <param name="side">Side choice number (1 to 3)</param>
        /// <param name="dessert">Dessert choice number (1 to 3)</param>
        /// <returns>Total calories as a number.</returns>
        /// <example>
        /// GET /api/Question1_2/HamburgerCombo?burger=1&drink=2&side=3&dessert=1
        /// Returns: 818
        /// </example>
        [HttpGet("HamburgerCombo")]
        public IActionResult HamburgerCombo(int burger, int drink, int side, int dessert)
        {
            int[] burgerCals = { 461, 431, 420 };
            int[] drinkCals = { 130, 160, 118 };
            int[] sideCals = { 100, 57, 70 };
            int[] dessertCals = { 167, 266, 75 };

            if (burger < 1 || burger > 3 || drink < 1 || drink > 3 || side < 1 || side > 3 || dessert < 1 || dessert > 3)
            {
                return BadRequest("All choices must be 1, 2, or 3.");
            }

            int total = burgerCals[burger - 1] + drinkCals[drink - 1] + sideCals[side - 1] + dessertCals[dessert - 1];
            return Ok(total);
        }
    }
}
