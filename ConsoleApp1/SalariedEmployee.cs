using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellis_PolyPayroll
{
    internal class SalariedEmployee : Employee
    {
        private decimal weeklyPay; // salary should not change

        public SalariedEmployee(string FirstName, string LastName, string SSN, decimal WeeklyPay)
        {
            weeklyPay = WeeklyPay;
            base.PayType = PayrollType.Salaried;
            base.SetPayableAmount = WeeklyPay;
        }
    }
}
