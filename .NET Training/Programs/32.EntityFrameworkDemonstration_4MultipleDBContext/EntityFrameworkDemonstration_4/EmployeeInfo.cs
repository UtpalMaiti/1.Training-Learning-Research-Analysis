//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDemonstration_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Salary { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public Nullable<int> DeptId { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public byte[] VersionInfo { get; set; }
    }
}
