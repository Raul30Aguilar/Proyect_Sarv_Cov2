using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Coronavirus_Aplicacion.Models;

namespace Coronavirus_Aplicacion.Controllers
{
    public class ListadoController : Controller
    {
        private sars_cov_2Entities  bd = new sars_cov_2Entities();

        // GET: Listado

        public ActionResult Listado(ciudadano model)
        {
            ViewBag.tipo_documento = new SelectList(bd.tipo_documento, "idTipoDocumento", "desTipoDocumento");
            return View(bd.ciudadano.ToList());
        }

        [HttpPost]
        public ActionResult Listado(int tipo_documento)
        {
            ViewBag.tipo_documento = new SelectList(bd.tipo_documento, "idTipoDocumento", "desTipoDocumento");
            var tipo = bd.ciudadano.Include(x => x.tipo_documento).Where(a => a.idtipodocumento == tipo_documento);
            return View(tipo.ToList());

        }







        /*
        public ActionResult GetData()
        {
            using (MiSistemaEntities3 db = new MiSistemaEntities3())
            {
                List<ciudadano> ciuList = db.ciudadano.ToList<ciudadano>();
                return Json(new { data = ciuList }, JsonRequestBehavior.AllowGet);
            }
        }
        */
    }
}