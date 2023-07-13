using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstration_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EmployeeDBEntities();

            var empList = dbContext.GetAllemployees();

            Console.WriteLine("Displaying the List of Employees");

            foreach(var emp in empList)
            {
                Console.WriteLine(emp.Id+"\t"+emp.Name+"\t"+emp.Location+"\t"+emp.Salary);
            }
            //Console.WriteLine("Understanding the Concepts of Entity Framework");

            //Console.WriteLine("Please Enter Employee ID whose record needs to be Deleted from MyOrgDB");
            //int idToDelete = int.Parse(Console.ReadLine());

            //MyOrgDBEntities dbContext_MyOrg = new MyOrgDBEntities();

            //using (var dbTransaction = dbContext_MyOrg.Database.BeginTransaction())
            //{
            //    try
            //    {
            //        var empToDelete = dbContext_MyOrg.EmployeeInfoes.Find(idToDelete);

            //        if (empToDelete != null)
            //        {
            //            dbContext_MyOrg.EmployeeInfoes.Remove(empToDelete);
            //            dbContext_MyOrg.SaveChanges();
            //        }

            //        Console.WriteLine("Please Enter the Employee ID whose Record needs to be retrieved");
            //        int Id = int.Parse(Console.ReadLine());

            //        EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //        var employee = dbContext.EmpInfoes.Find(Id);

            //        if (employee != null)
            //        {
            //            employee.Name = "Abhinav";
            //            employee.Salary = 12345;

            //            employee.DepartmentId = 5;
            //        }

            //        dbContext.SaveChanges();

            //        dbTransaction.Commit();
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        dbTransaction.Rollback();
            //    }
            //}
            //Console.WriteLine("Please Enter the Employee ID whose Record needs to be Deleted");
            //int idToDelete = int.Parse(Console.ReadLine());

            //var empToDelete = dbContext.EmpInfoes.Find(idToDelete);

            //if (empToDelete != null)
            //{
            //    dbContext.EmpInfoes.Remove(empToDelete);
            //}

            //EmpInfo newEmployee = new EmpInfo
            //{
            //    Id=107,Name="Pragim",Location="Bangalore",Salary=25000,DepartmentId=5
            //};

            //dbContext.EmpInfoes.Add(newEmployee);           

            //dbContext.SaveChanges();
        }
    }
}
