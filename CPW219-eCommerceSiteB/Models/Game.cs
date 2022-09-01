using System.ComponentModel.DataAnnotations;

namespace CPW219_eCommerceSite.Models
{
    /// <summary>
    /// Represents a single game for purchase
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Unique identifier for each game product
        /// </summary>
        [Key]
        public int GameId { get; set; }
        /// <summary>
        /// Title of the video game
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// Sales price of the game
        /// </summary>
        [Range(0, 1000)]
        public double Price { get; set; }

        // Todo: Add Rating
    }
}
