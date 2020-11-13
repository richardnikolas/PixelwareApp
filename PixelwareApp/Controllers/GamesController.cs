﻿using PixelwareApp.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace PixelwareApp.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var games = _context.Games.ToList();
            return View(games);
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games
                            .Include(g => g.Genre)
                            .Include(g => g.Publisher)
                            .SingleOrDefault(g => g.Id == id);

            if (game == null)
                return HttpNotFound();

            return View(game);
        }
    }
}