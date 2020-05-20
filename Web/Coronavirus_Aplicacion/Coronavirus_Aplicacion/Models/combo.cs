using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coronavirus_Aplicacion.Models
{
    public class combo
    {

        private SARS_COV_2Entities1 bd = new SARS_COV_2Entities1();


        public List<ESTADO_CIUDADANO> GetEstado()
        {
            List<ESTADO_CIUDADANO> lista = bd.ESTADO_CIUDADANO.ToList();
            return lista;
        }
    }
}