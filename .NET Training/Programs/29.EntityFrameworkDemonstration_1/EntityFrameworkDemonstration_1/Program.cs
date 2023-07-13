using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemonstration_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //var deptList = dbContext.DeptInfoes;

            //foreach (var dept in deptList)
            //{
            //    Console.WriteLine(dept.Id + "\t" + dept.Name);
            //    Console.WriteLine("----------------------------------------------");

            //    foreach (var emp in dept.EmpInfoes)
            //    {
            //        Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Salary);
            //    }

            //    Console.WriteLine("\n\n");
            //}
            //Console.ReadLine();
            //Console.WriteLine("Please Enter the Employee ID whose Record needs to be Retrieved");
            //int Id = int.Parse(Console.ReadLine());

            //EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //EmpInfo emp = dbContext.EmpInfoes.Find(Id);

            //if (emp != null)
            //{
            //    Console.WriteLine("Employee Details are : \n");

            //    Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Location + "\t" + emp.Salary);

            //    Console.WriteLine("Understanding the Concepts of Entity Framework");

            //    Console.WriteLine("Please Enter the Updated Name");

            //    emp.Name = Console.ReadLine();

            //    Console.WriteLine("Please Enter the Updated Location");

            //    emp.Location = Console.ReadLine();

            //    Console.WriteLine("Please Enter the Updated Salary");

            //    emp.Salary = int.Parse(Console.ReadLine());

            //    foreach (var property in dbContext.Entry(emp).OriginalValues.PropertyNames)
            //    {
            //        var originalValue = dbContext.Entry(emp).OriginalValues[property].ToString();

            //        var currentValue = dbContext.Entry(emp).CurrentValues[property].ToString();

            //        Console.WriteLine(originalValue + "\t" + currentValue);

            //        if (originalValue != currentValue)
            //        {
            //            Console.WriteLine("Include Property : {0} in the Update Query", property);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No Changes are being made to Property : " + property);
            //        }
            //    }

            //    int noOfRowsAffected = dbContext.SaveChanges();

            //    if (noOfRowsAffected > 0)
            //    {
            //        Console.WriteLine("Changes are Saved to DB");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Changes are made to DB");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Employee Exists");
            //}

            Console.ReadLine();

            //EmpInfo emp = null;

            //using (EmployeeDBEntities dbContext = new EmployeeDBEntities())
            //{
            //    emp = dbContext.EmpInfoes.Find(Id);
            //}

            //if (emp != null)
            //{
            //    Console.WriteLine("Employee Details are : \n");

            //    Console.WriteLine(emp.Id+"\t"+emp.Name+"\t"+emp.Location+"\t"+emp.Salary);

            //    Console.WriteLine("Understanding the Concepts of Entity Framework");

            //    Console.WriteLine("Please Enter the Updated Name");

            //    emp.Name = Console.ReadLine();

            //    Console.WriteLine("Please Enter the Updated Location");

            //    emp.Location = Console.ReadLine();

            //    Console.WriteLine("Please Enter the Updated Salary");

            //    emp.Salary = int.Parse(Console.ReadLine());

            //    EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //    Console.WriteLine("State is : "+dbContext.Entry(emp).State);

            //dbContext.Entry(emp).State = System.Data.Entity.EntityState.Modified;

            //    dbContext.SaveChanges();
            //}
            //else
            //{
            //    Console.WriteLine("No Employee found");
            //}

            ////Delete Function in Ef
            Console.WriteLine("Please Enter the Employee ID whose Record to be Delete");
            int id = int.Parse(Console.ReadLine());

            EmployeeDBEntities dbContext = new EmployeeDBEntities();

            var empToDelete = dbContext.EmpInfoes.FirstOrDefault(e => e.Id == id);

            if (empToDelete != null)
            {
                //dbContext.EmpInfoes.Remove(empToDelete);
                Console.WriteLine(dbContext.Entry(empToDelete).State);

                dbContext.Entry(empToDelete).State = System.Data.Entity.EntityState.Deleted;

                Console.WriteLine(dbContext.Entry(empToDelete).State);
                //int noOfRowsAffected = dbContext.SaveChanges();

                //if (noOfRowsAffected > 0)
                //{
                //    Console.WriteLine("Record is Deleted");
                //}
                //else
                //{
                //    Console.WriteLine("Deletion has not happened");
                //}
            }
            else
            {
                Console.WriteLine("No Record to Delete");
            }
            //if (empToUpdate != null)
            //{
            //    Console.WriteLine(dbContext.Entry(empToUpdate).State);

            //    Console.WriteLine("Employee Details are : ");

            //    Console.WriteLine(empToUpdate.Name + "\t" + empToUpdate.Location + "\t" +
            //        empToUpdate.Salary + "\t" + empToUpdate.DepartmentId);

            //    Console.WriteLine("Please Enter Updated Name");
            //    empToUpdate.Name = Console.ReadLine();

            //    Console.WriteLine("Please Enter Updated Location");
            //    empToUpdate.Location = Console.ReadLine();

            //    Console.WriteLine("Please Enter Updated Salary");
            //    empToUpdate.Salary = int.Parse(Console.ReadLine());

            //    Console.WriteLine(dbContext.Entry(empToUpdate).State);

            //    int noOfRowsAffected = dbContext.SaveChanges();

            //    if (noOfRowsAffected > 0)
            //    {
            //        Console.WriteLine("Updation Successful");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Update is not happened");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("There is no Employee exists with the Entered ID");
            //}

            ////Ef Add Recored Function By Using Add Method Context
            //Console.WriteLine("Welcome to New Employee Registration Screen...");

            //Console.WriteLine("Please Enter Employee ID");
            //int id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Employee Name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Please Enter Employee Location");
            //string loc = Console.ReadLine();

            //Console.WriteLine("Please Enter Employee Salary");
            //int salary = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Employee Dept ID");
            //int deptId = int.Parse(Console.ReadLine());

            //EmpInfo employee = new EmpInfo
            //{
            //    Id = id,
            //    Name = name,
            //    Location = loc,
            //    Salary = salary,
            //    DepartmentId = deptId
            //};

            //EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //dbContext.EmpInfoes.Add(employee);

            //int noOfRowsAffected = dbContext.SaveChanges();

            //if (noOfRowsAffected > 0)
            //{
            //    Console.WriteLine("New Employee is Registered");
            //}
            //else
            //{
            //    Console.WriteLine("No Record is Inserted");
            //}

            //// Second Program
            //List<int> list = new List<int>
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            ////Deferred Execution
            //var evenNumberList = from n in list
            //                     where n % 2 == 0
            //                     select n;

            ////Immediate Execution
            //var evenNumberList1 = (from n in list
            //                       where n % 2 == 0
            //                       select n).ToList();

            //Console.WriteLine("List of Even Numbers\n---------------------------");

            //foreach (var i in evenNumberList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("List of Even Numbers\n---------------------------");

            //foreach (var i in evenNumberList)
            //{
            //    Console.WriteLine(i);
            //}

            ////first program with LINQ Expression Method
            //EmployeeDBEntities dbContext = new EmployeeDBEntities();

            ////var empList = dbContext.EmpInfoes;
            //var empList = from e in dbContext.EmpInfoes
            //              select e

            //Console.WriteLine("List of Employees...\n");

            //foreach (EmpInfo emp in empList)
            //{
            //    Console.WriteLine(emp.Id + "\t" + emp.Name + "\t" + emp.Location + "\t" + emp.Salary + "\t" +
            //        emp.DepartmentId);
            //}

            ////Console.WriteLine(JsonConvert.SerializeObject(empList));
        }
    }
}