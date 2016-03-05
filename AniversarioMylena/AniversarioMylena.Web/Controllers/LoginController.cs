using System.Web.Mvc;
using System.Web.Security;
using AniversarioMylena.Web.Authentictions;

namespace AniversarioMylena.Web.Controllers
{
    public class LoginController : Controller
    {

        [HttpPost]
        public ActionResult Login()
        {
            var usuarioAutentiado = new UsuarioLogado("aniver@email.com", new string[] {"ANIVER"}, "Mylena");

                if (usuarioAutentiado.IsValid)
                {
                    FormsAuthentication.SetAuthCookie(usuarioAutentiado.Email, true);
                    Session["USUARIO_LOGADO"] = usuarioAutentiado;
                    return RedirectToAction("Aniversario", "Main");
                }


            return RedirectToAction("Index", "Main");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            if (Session["USUARIO_LOGADO"] != null)
            {
                FormsAuthentication.SignOut();
            }
            
            return RedirectToAction("Index", "Main");
        }
    }
}