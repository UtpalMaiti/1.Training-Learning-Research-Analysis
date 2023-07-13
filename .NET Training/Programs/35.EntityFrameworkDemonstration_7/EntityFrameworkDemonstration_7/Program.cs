using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameworkDemonstration_7
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities dbContext = new EmployeeDBEntities();

            //dbContext.Configuration.LazyLoadingEnabled = false;

            var deptData = dbContext.DeptInfoes.Include(d => d.EmpInfoes).Include(d=>d.EmpInfoes);

            foreach(var dept in deptData)
            {
                Console.WriteLine(dept.Id+"\t"+dept.Name);

                Console.WriteLine("-------------------------------------------");

                foreach(var emp in dept.EmpInfoes)
                {
                    Console.WriteLine(emp.Id+"\t"+emp.Name+"\t"+emp.Salary);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
