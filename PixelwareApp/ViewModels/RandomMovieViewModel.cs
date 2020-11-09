using PixelwareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PixelwareApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Game Game { get; set; }
        public List<Publisher> Publishers { get; set; }
    }
}