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
            var menuData = Main.GetDataTable("SELECT * FROM MenuSetup order by Title asc");
            foreach (DataRow Item in menuData.Rows)
            {
                var menuItem = new Menu();
                menuItem.Id = Convert.ToInt32(Item["ID"]);
                menuItem.MainID = Convert.ToInt32(Item["MainID"]);
                menuItem.Type = Item["Type"].ToString();
                menuItem.Title = Item["Title"].ToString();
                menuItem.Name = Item["Name"].ToString();
                model.Add(menuItem);
            }
            return View(model);
        }

    }
}