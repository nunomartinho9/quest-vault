﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace questvault.Models
{
    [PrimaryKey(nameof(GameId), nameof(GenreId))]
    /// <summary>
    /// Represents a many-to-many relationship between Game and Genre entities.
    /// </summary>
    public class GameGenre
    {
        /// <summary>
        /// Gets or sets the ID of the game.
        /// </summary>
        [Column(Order = 0)]
        public long GameId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the genre.
        /// </summary>
        [Column(Order = 1)]
        public long GenreId { get; set; }
        /// <summary>
        /// Gets or sets the navigation property for the game.
        /// </summary>
        [ForeignKey(nameof(GameId))]
        public virtual Game? Game { get; set; }
        /// <summary>
        /// Gets or sets the navigation property for the genre.
        /// </summary>
        [ForeignKey(nameof(GenreId))]
        public virtual Genre? Genre { get; set; }
    }
}
