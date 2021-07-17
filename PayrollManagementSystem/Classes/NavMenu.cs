using PayrollManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollManagementSystem
{
    public class NavMenu
    {
        public static int GetCount(IEnumerable<Menu> menu, int ID)
        {
            int count = 0;
            foreach (var item in menu)
            {
                if (item.MainID == ID) count++;
            }
            return count;
        }
        public static List<Menu> GetSubMenuItem(IEnumerable<Menu> menu, int ID)
        {
            var subMenu = new List<Menu>();
            foreach (var item in menu)
            {
                if (item.MainID == ID)
                {
                    var menuItem = new Menu();
                    menuItem.Id = item.Id;
                    menuItem.MainID = item.MainID;
                    menuItem.Type = item.Type;
                    menuItem.Title = item.Title;
                    menuItem.Name = item.Name;
                    subMenu.Add(menuItem);
                }
              
            }
            return subMenu;
        }

    
    }
}