using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REM.Models;
using stdioCore;

namespace REM.Controllers
{
    public class DashboardController : Controller
    {
        SessionModel _Session;
        DatabaseLibrary dbl;
        TablesController tabels;

        public ActionResult Index()
        {
            _Session = Session["userInfo"] as SessionModel;
            if (_Session != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AllAdverts()
        {
            ViewBag.Header = "Tüm İlanlar";
            _Session = Session["userInfo"] as SessionModel;
            dbl = new DatabaseLibrary(_Session._companyName);
            tabels = new TablesController();
            List<AdvertModal> all = tabels.tblAdverts.ToList();
            return View(all);
        }

        public ActionResult AllCompanies()
        {
            dbl = new DatabaseLibrary();
            List<GlobaCompanyModel> all = dbl.tbl.glblCompany.ToList();
            return View(all);
        }
    }
}