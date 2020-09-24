using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class HourlyEmployee : Employee
    {
        public decimal wage;
        public decimal hours;
        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber,decimal wage,decimal hours)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.wage = wage;
            this.hours = hours;
        }
        public override string ToString()
        {
            return $"Hourly Employee : {FirstName} {LastName}\nSocial security number : {SocialSecurityNumber}\nHours : {hours}\nWage : ${wage}\nEarned : ${Earnings()}";
        }
        public override decimal Earnings()
        {
            if(hours<=40)
            {
                return hours * wage;
            }
            else
            {
                return hours * wage + (hours - 40) * 1.5M * wage;
            }
        }
    }
}
