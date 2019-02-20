using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VistasParciales.Models;

namespace VistasParciales.Controllers
{
    public class CochesController : Controller
    {
        ConcesionarioModel concesionario;

        public CochesController()
        {
            this.concesionario = new ConcesionarioModel();
        }

        public ActionResult _ListaCoches()
        {
            List<Coche> coches = this.concesionario.GetCoches();
            return PartialView(coches);
        }
    }
}