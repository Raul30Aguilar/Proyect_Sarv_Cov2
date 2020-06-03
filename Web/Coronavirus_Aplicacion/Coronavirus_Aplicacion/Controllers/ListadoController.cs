using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        private sars_cov_2Entities bd = new sars_cov_2Entities();

        // GET: Listado

        public ActionResult Listado(ciudadano model)
        {

            ViewBag.estado = new SelectList(bd.tipo_estado, "idestado", "estado");
            return View(bd.estado_ciudadano.ToList());

            //ViewBag.estado = new SelectList(bd.tipo_estado, "idestado", "estado");
            //return View(bd.estado_ciudadano.ToList());
        }

        [HttpPost]
        public ActionResult Listado(int estado)
        {
            ViewBag.estado = new SelectList(bd.tipo_estado, "idestado", "estado");
            var tipo = bd.estado_ciudadano.Include(x => x.tipo_estado).Where(a => a.idestado == estado);
            return View(tipo.ToList());

        }
        

        public ActionResult Detalle(int? doc)
        {
            if (doc == null)
            { 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                
            }
            ciudadano obj = bd.ciudadano.Find(doc);

            if (obj == null)
            {
                HttpNotFound();
            }
            return View(obj);
        }


        public ActionResult Triaje(int? docc)
        {
            if (docc == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var rdj = bd.triaje.FirstOrDefault(x => x.docciudadano == docc);

            if (rdj == null)
            {
                HttpNotFound();
            }
            return View(rdj);
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