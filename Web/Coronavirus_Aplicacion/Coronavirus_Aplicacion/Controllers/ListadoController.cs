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
        private SARS_COV_2Entities3  bd = new SARS_COV_2Entities3();

        // GET: Listado

        public ActionResult Listado(CIUDADANO model)
        {
            ViewBag.tipo_documento = new SelectList(bd.TIPO_DOCUMENTO, "idTipoDocumento", "desTipoDocumento");
            return View(bd.CIUDADANO.ToList());
        }

        [HttpPost]
        public ActionResult Listado(int tipo_documento)
        {
            ViewBag.tipo_documento = new SelectList(bd.TIPO_DOCUMENTO, "idTipoDocumento", "desTipoDocumento");
            var tipo = bd.CIUDADANO.Include(x => x.TIPO_DOCUMENTO).Where(a => a.idTipoDocumento == tipo_documento);
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