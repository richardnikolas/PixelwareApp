using System;
using System.Web.Mvc;

namespace PixelwareApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}