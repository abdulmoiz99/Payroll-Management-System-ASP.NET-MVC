using PayrollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayrollManagementSystem.Classes;
using System.Data;

namespace PayrollManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index(Menu menu)
        {
            var model = new List<Menu>();
            Main.CreateNavMenu(model);
            return View(model);
        }
    }
}