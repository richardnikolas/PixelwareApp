using System;
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

        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public Publisher Publisher { get; set; }
        [Display(Name = "Publisher")]
        [Required]
        public byte PublisherId { get; set; }
        
        public DateTime ReleaseDate { get; set; }
    }
}