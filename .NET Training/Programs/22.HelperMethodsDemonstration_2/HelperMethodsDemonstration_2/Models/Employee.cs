using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperMethodsDemonstration_2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int Salary { get; set; }

        public Role Role { get; set; }
    }
    public enum Role
    {
        Employee,Lead,Manager
    }
}