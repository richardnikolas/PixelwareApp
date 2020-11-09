using PixelwareApp.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace PixelwareApp.Controllers
{
    public class PublishersController : Controller
    {
        private ApplicationDbContext _context;

        public PublishersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var publishers = _context.Publishers.ToList();

            return View(publishers);
        }

        public ActionResult Details(int id)
        {
            var publisher = _context.Publishers.SingleOrDefault(p => p.Id == id);

            if (publisher == null)
                return HttpNotFound();

            return View(publisher);
        }
    }
}