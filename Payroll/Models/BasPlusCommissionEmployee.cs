using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Models
{
    public class BasPlusCommissionEmployee : CommissionEmployee
    {
       
        public decimal weekly;
        public BasPlusCommissionEmployee(string firstName, string lastName, string socialSecurityNumber,decimal sales,decimal percentagerates, decimal weekly)
            : base(firstName, lastName, socialSecurityNumber, sales,percentagerates)
        {

        }
       
        public override string ToString()
        {
            return $"Base Commission Employee : {FirstName} {LastName}\nSocial security number : {SocialSecurityNumber}\nSales : ${sales}\nCommission Rate : {percentagerates}\nEarned : ${Earnings()}";
        }
        public override decimal Earnings()
        {
            return 150 + base.Earnings();
        }
    }
}
