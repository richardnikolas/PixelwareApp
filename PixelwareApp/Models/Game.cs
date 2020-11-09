﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PixelwareApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }

        public string Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        
        public DateTime ReleaseDate { get; set; }
    }
}