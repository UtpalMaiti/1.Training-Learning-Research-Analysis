using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BundlingMinificationDemonstration.Models
{
    public class EmployeeRepository
    {
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee {Id=101,Name="Abhinav",Location="Bangalore",Salary=12345,DeptId=1 },
                new Employee {Id=102,Name="Abhishek",Location="Chennai",Salary=23456,DeptId=2 },
                new Employee {Id=103,Name="Ajay",Location="Bangalore",Salary=34567,DeptId=1 },
                new Employee {Id=104,Name="Anil",Location="Chennai",Salary=45678,DeptId=1 },
                new Employee {Id=105,Name="Akash",Location="Bangalore",Salary=56789,DeptId=2 },
                new Employee {Id=106,Name="Akshay",Location="Bangalore",Salary=67890,DeptId=1 },
                new Employee {Id=107,Name="Rohit",Location="Bangalore",Salary=78900,DeptId=1 }
            };
        }
    }
}