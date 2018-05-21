using REM.App_Start;
using REM.Models;
using System.Web.Mvc;
using System.Web.UI;

namespace REM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session.Keys.Count != 0)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                Session.Clear();
                Session.RemoveAll();
                Session.Abandon();
                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel _user)
        {
            AuthConfig auth = new AuthConfig();
            auth._userEmail = _user.userEmail;
            auth._password = _user.userPassword;
            auth._companyName = _user.t_companyName;
            SessionModel _S = auth.loginAuthentication();
            if (_S._roleName != null)
            {
                Session["userInfo"] = _S;
                Session["userRoleName"] = _S._roleName;
                return RedirectToAction("Index","Dashboard");
            } else
            {
                Session.Clear();
                Session.RemoveAll();
                Session.Abandon();
                return Index();
            }

        }
    }
}