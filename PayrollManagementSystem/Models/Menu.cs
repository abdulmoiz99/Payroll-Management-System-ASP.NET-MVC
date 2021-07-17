using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayrollManagementSystem.Models
{
    public class Menu
    {
        public int Id { get; set; }

        public int MainID { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }
    }
}