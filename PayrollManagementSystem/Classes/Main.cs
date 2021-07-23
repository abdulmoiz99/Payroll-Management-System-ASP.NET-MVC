
using PayrollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace PayrollManagementSystem.Classes
{
    public class Main
    {
        public static DataTable GetDataTable(string Query)
        {
            if (SQL.Con.State == ConnectionState.Open)
            {
                SQL.Con.Close();
            }
            SQL.Con.Open();
            DataTable datasheets = new DataTable();
            SqlCommand command = new SqlCommand(Query, SQL.Con);
            var adapter = new SqlDataAdapter(command);
            adapter.Fill(datasheets);
            adapter.Dispose();
            return datasheets;
        }
        public static bool verifyUser(string name, string password)
        {
            string oPassword = "";
            oPassword = SQL.ScalarQuery("Select UserPassword from Users where username='" + name + "'");
            if (string.Compare(password, oPassword) == 0) return true;
            else return false;
        }
        public static void CreateNavMenu(List<Menu> model)
        {
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
        }
    }
}