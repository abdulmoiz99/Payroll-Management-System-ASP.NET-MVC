using PayrollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PayrollManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index(Menu menu)
        {
            string con = @"Data Source=ABDUL-MOIZ\SQLEXPRESS;Initial Catalog=PayrollManagementSystem;Integrated Security=True;Pooling=False";
            String sql = "SELECT * FROM MenuSetup order by Title asc";
            SqlCommand cmd = new SqlCommand(sql, SQL.Con);

            var model = new List<Menu>();
            if (SQL.Con.State == System.Data.ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var menuItem = new Menu();
                menuItem.Id = Convert.ToInt32(rdr["ID"]);
                menuItem.MainID = Convert.ToInt32(rdr["MainID"]);
                menuItem.Type = rdr["Type"].ToString();
                menuItem.Title = rdr["Title"].ToString();
                menuItem.Name = rdr["Name"].ToString();
                model.Add(menuItem);
            }
            return View(model);
        }

    }
}