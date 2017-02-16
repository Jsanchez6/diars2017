using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaDominio;
using CapaLogica;

namespace CapaPresentacion.Controllers
{
    public class LoginIntranetController : Controller
    {
    
        [HttpGet]
        public ActionResult VerificarAcceso()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult VerificarAcceso(FormCollection frm)
        {

            try
            {

            }
            catch(Exception e)
            {
                throw e;
            }

        }
	}
}