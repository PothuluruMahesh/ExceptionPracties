using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPracties
{
    class CompanyClass
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1(101,"Mahesh",15000.00,"Bangalor","BizRunTime");
            Console.WriteLine("Employee Id :"+emp[0]);
            Console.WriteLine("Employee Name :" + emp[1]);
            Console.WriteLine("Employee Salary :" + emp[2]);
            Console.WriteLine("Employee Location :" + emp[3]);
            Console.WriteLine("Employee Company :" + emp[4]);
            Console.WriteLine("\n=====================================\n");
            Employee1 emp2 = new Employee1(103, "Naresh", 100000.00, "Bangalor", "IBM");
            Console.WriteLine("Employee Id :" + emp2[0]);
            Console.WriteLine("Employee Name :" + emp2[1]);
            Console.WriteLine("Employee Salary :" + emp2[2]);
            Console.WriteLine("Employee Location :" + emp2[3]);
            Console.WriteLine("Employee Company :" + emp2[4]);
            Console.WriteLine("\n=====================================\n");
            Employee1 emp1 = new Employee1(102, "MaheshReddy", 25000.00, "Kadapa", "HP");
            Console.WriteLine("Employee Id :" + emp1[0]);
            Console.WriteLine("Employee Name :" + emp1[1]);
            Console.WriteLine("Employee Salary :" + emp1[2]);
            Console.WriteLine("Employee Location :" + emp1[3]);
            Console.WriteLine("Employee Company :" + emp1[4]);
            Console.WriteLine("\n=====================================\n");
        }
    }
}
