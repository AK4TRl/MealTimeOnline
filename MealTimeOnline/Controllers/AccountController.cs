using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MealTimeOnline.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: Account/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Account/Info
        public ActionResult Info()
        {
            return View();
        }

        // GET: Accoutn/Security
        public ActionResult Security()
        {
            return View();
        }

        // GET: Accoutn/Modifypassword
        public ActionResult Modifypassword()
        {
            return View();
        }

        // GET: Accoutn/Evaluated
        public ActionResult Evaluated()
        {
            return View();
        }

        // GET: Accoutn/AccountBalance
        public ActionResult AccountBalance()
        {
            return View();
        }

        // GET: Accoutn/BusinessVerified
        public ActionResult BusinessVerified()
        {
            return View();
        }
    }
}