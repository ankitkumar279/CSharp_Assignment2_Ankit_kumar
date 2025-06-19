using Microsoft.AspNetCore.Mvc;

namespace Assignment2_API_AK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Question5 : ControllerBase
    {
        /// <summary>
        /// This method checks if a time string is a palindrome.
        /// For example, "12:21" is a palindrome because it reads the same backward.
        /// </summary>
        /// <param name="time">The time in HH:MM format.</param>
        /// <returns>True if the time is a palindrome, otherwise false.</returns>
        /// <example>
        /// GET /api/Question5/IsTimePalindrome?time=12:21
        /// Returns: true
        /// </example>
        [HttpGet("IsTimePalindrome")]
        public IActionResult IsTimePalindrome(string time)
        {
            if (string.IsNullOrEmpty(time))
                return Ok(false);

            string t = time.Replace(":", "");
            char[] arr = t.ToCharArray();
            System.Array.Reverse(arr);
            string rev = new string(arr);

            bool isPal = t == rev;
            return Ok(isPal);
        }
    }
}
