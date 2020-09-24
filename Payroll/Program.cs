using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll.Models;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payroll.....");
            Console.WriteLine();
            HourlyEmployee he = new HourlyEmployee("Diane", "Carter", "WW001",12.5M,41);
            CommissionEmployee ce = new CommissionEmployee("Peter", "Parker", "Spider001",3000,0.07M);
            BasPlusCommissionEmployee bce = new BasPlusCommissionEmployee("Bruce", "Banner", "HULK001",3000,0.1M,150);
            SalariedEmployee se = new SalariedEmployee("Clark", "Kent", "SPMN001",400);
            Console.WriteLine($"Employee processed individualy :");
            Console.WriteLine();
            Console.WriteLine($"{he.ToString()} \n");
            Console.WriteLine();
            Console.WriteLine($"{ce.ToString()} \n");
            Console.WriteLine();
            Console.WriteLine($"{bce.ToString()} \n");
            Console.WriteLine();
            Console.WriteLine($"{se.ToString()} \n");
            var Employees = new List<Employee> { he, ce, bce, se };
            Console.WriteLine("=============================================");
            Console.WriteLine("Employee processed polymorphically :");
            Console.WriteLine();
            foreach(var currentEmployee in Employees)
            {
                Console.WriteLine(currentEmployee);
                if(currentEmployee is BasPlusCommissionEmployee)
                {
                    var employee = (BasPlusCommissionEmployee)currentEmployee;
                    employee.weekly = employee.weekly * 1.10M;
                    Console.WriteLine("Total earned with the 10% increase : $" + 1.10M*employee.Earnings());
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
