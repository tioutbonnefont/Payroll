using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class SalariedEmployee : Employee
    {
        public decimal weeklysalary;
        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber,decimal weeklysalary)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.weeklysalary = weeklysalary;
        }
       
        public override string ToString()
        {
            return $"Salaried Employee : {base.ToString()}\nWeekly Salary : ${weeklysalary}\nEarned : ${Earnings()}";
               
        }
        public override decimal Earnings()
        {
            return weeklysalary;
        }
    }
}
