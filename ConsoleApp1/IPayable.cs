using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ellis_PolyPayroll
{
    interface IPayable
    {
        public decimal GetPayableAmount
        {
            get;
        }
    }

    public enum PayrollType
    {
        Salaried,
        Hourly,
        Invoice
    }
}
