using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelperMethodsDemonstration_1.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public int Salary { get; set; }

        public string Qualification { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOJ { get; set; }

        public bool IsPermanent { get; set; }

        public Role Role { get; set; }

        public Address CurrentAddress { get; set; }

        public Address PermanentAddress { get; set; }
    }

    public enum Role
    {
        Employee, Lead, Manager
    }

    public class Address
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}