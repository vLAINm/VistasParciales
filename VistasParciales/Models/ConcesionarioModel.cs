using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VistasParciales.Models
{
    public class ConcesionarioModel
    {
        ConcesionarioDataContext context;

        public ConcesionarioModel ()
        {
            this.context = new ConcesionarioDataContext();
        }

        public List<Coche> GetCoches ()
        {
            var consulta = from datos in context.Coches
                           select datos;
            return consulta.ToList();
        }
    }
}
