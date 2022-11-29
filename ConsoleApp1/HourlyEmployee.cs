using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellis_PolyPayroll
{
    internal class HourlyEmployee : Employee
    {
        private decimal hourlyPay;
        private decimal overtime = 1.5M;
        private int weeklyHours = 40;
        private decimal earnings;
        

        public HourlyEmployee(string FirstName, string LastName, string SSN, decimal HourlyPay, int WeeklyHours)
        {
            hourlyPay = HourlyPay;
            weeklyHours = WeeklyHours;
            base.PayType = PayrollType.Hourly;
            base.SetPayableAmount = Earnings();
        }

        public decimal Earnings()
        {
            if (weeklyHours <= 40)
            {
                earnings = hourlyPay * weeklyHours;
                return earnings;
            }
            else
            {
                earnings = (hourlyPay * weeklyHours) * overtime;
                return earnings;
            }
        }
    }
}
