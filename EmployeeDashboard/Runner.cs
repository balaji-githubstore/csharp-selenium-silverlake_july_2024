using SilverLake.EmployeeDashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Runner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "SilverLakes";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            emp1.empId = 101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "A";
            

            emp2.empId = 102;
            emp2.empName = "kim";
            emp2.empSalary = 6000;
            emp2.empPerformance = "C";
            

            emp2.DisplayEmployeeDetail();
            emp1.DisplayEmployeeDetail();
            emp3.DisplayEmployeeDetail();

            emp1.AddBonus();
            emp2.AddBonus();

            emp2.DisplayEmployeeDetail();
            emp1.DisplayEmployeeDetail();
            emp3.DisplayEmployeeDetail();

        }
    }
}
