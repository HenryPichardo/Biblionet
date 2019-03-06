using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblionet.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string usuario, string password)
        {
            if (usuario == "henry" && password == "123456klk")
                return RedirectToAction("Index", "Home");
            else
                return View();
        }
    }
}