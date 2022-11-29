using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellis_PolyPayroll
{
    internal class Employee : IPayable
    {
        private string FirstName;
        private string SSN;
        private string LastName;
        private PayrollType payrollType;
        private decimal PayableAmount;

        public decimal SetPayableAmount
        {
            set { PayableAmount = value; }
        }
        public decimal GetPayableAmount
        {
            get => PayableAmount;
        }

        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            SSN = ssn;
            LastName = lastName;
        }

        public PayrollType PayType
        {
            set { payrollType = value; }
            get { return payrollType; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
