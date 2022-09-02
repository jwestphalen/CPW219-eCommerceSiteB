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

    /// <summary>
    /// A single video game that has been added to the users
    /// shopping cart cookie
    /// </summary>
    public class CartGameViewModel
    {
        public int GameId { get; set; }

        public string Title { get; set; }

        public double Price { get; set; }
    }
}
