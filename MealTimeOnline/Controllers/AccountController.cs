using System.Linq;
using System.Web.Mvc;
using MealTimeOnline.ViewModels.Auth;
using MealTimeOnline.DataAccessLayer;
using System.Web.Security;
using MealTimeOnline.Models;

namespace MealTimeOnline.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        MtoDataContext db = new MtoDataContext();
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

        // GET: Account/Modifypassword
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Modifypassword()
        {
            return View();
        }

        // Post: Account/Modifypassword
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Modifypassword(ModifypwViewModel model)
        {
            var usr = db.Users.SingleOrDefault(c => c.Username == model.Username && c.Password == model.oldPassword);
            if (usr == null)
            {
                ModelState.AddModelError("", "密码错误");
            }
            else
            {
                db.Users.SingleOrDefault(c => c.Username == model.Username && c.Password == model.oldPassword).Password = model.NewPassword;
                db.SaveChanges();
                return RedirectToAction("Index", "Account");
            }
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

        // GET: Accoutn/Addresses
        public ActionResult Addresses()
        {
            return View();
        }

        // GET: Accoutn/RecentOrder
        public ActionResult RecentOrder()
        {
            return View();
        }

        // GET: Accoutn/RedPacket
        public ActionResult RedPacket()
        {
            return View();
        }
    }
}