using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AniversarioMylena.Web.Authentictions;

namespace AniversarioMylena.Web.Controllers
{
    public class MainController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["USUARIO_LOGADO"] != null)
            {
                FormsAuthentication.SignOut();
            }

            return View();
        }

        [Autorizador]
        [HttpGet]
        public ActionResult Aniversario()
        {
            return View();
        }
    }
}