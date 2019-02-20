using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VistasParciales.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Noticias
        public ActionResult Noticias()
        {
            return View();
        }

        // GET: Coches
        public ActionResult Coches()
        {
            return View();
        }

        // GET: Contacto
        public ActionResult Contacto()
        {
            return View();
        }
    }
}