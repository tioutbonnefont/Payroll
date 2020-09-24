using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class CommissionEmployee : Employee
    {
        public decimal sales;
        public decimal percentagerates;
        public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber,decimal sales,decimal percentagerates)
            : base(firstName, lastName, socialSecurityNumber)
        {
            this.sales = sales;
            this.percentagerates = percentagerates;
        }
        public override string ToString()
        {
            return $"Commission Employee : {FirstName} {LastName}\nSocial security number : {SocialSecurityNumber}\nSales : ${sales}\nCommission rate : {percentagerates}\nEarned : ${Earnings()}";
        }
        public override decimal Earnings()
        {
            return sales * percentagerates;
        }
    }
}
