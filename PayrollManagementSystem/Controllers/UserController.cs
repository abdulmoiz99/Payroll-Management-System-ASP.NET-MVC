using PayrollManagementSystem.Classes;
using PayrollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayrollManagementSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View("~/Views/User/Login.cshtml");

        }
        public ActionResult Verify(User user)
        {
            if (Main.verifyUser(user.Username, user.Password))
            {
                var model = new List<Menu>();
                Main.CreateNavMenu(model);
                return View("~/Views/Dashboard/index.cshtml",model);
            }
            else
            {
                return View("~/Views/User/LoginFailed.cshtml");
            }
        }
    }
}