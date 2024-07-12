using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverLake.EmployeeDashboard
{
    public class Employee
    {
        public int empId;
        public string empName;
        public double empSalary;
        public string empPerformance;
        public static string companyName;

        public void DisplayEmployeeDetail()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("Employee Performance:" + empPerformance);
            Console.WriteLine("Company Name:" + Employee.companyName);
            Console.WriteLine("--------------------------------------");
        }

        public void AddBonus()
        {
            if (empPerformance == "A")
            {
                empSalary = empSalary + 1000;
            }
            else if (empPerformance == "B")
            {
                empSalary = empSalary + 500;
            }
            else if (empPerformance == "C")
            {
                empSalary = empSalary + 100;
            }
        }

        public static Employee GetInstance()
        {
            Employee e = new Employee();
            return e;
        }

        public static void CheckSalary(Employee e1, Employee e2)
        {
            if (e1.empSalary > e2.empSalary)
            {
                Console.WriteLine("Employee 1 - Higher Salary");
            }
            else if (e1.empSalary < e2.empSalary)
            {
                Console.WriteLine("Employee 2 - Higher Salary");
            }
            else
            {
                Console.WriteLine("Employee 1 - Employee 2 - Same Salary");
            }
        }

    }

}
