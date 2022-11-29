using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellis_PolyPayroll
{
    internal class Invoice : IPayable
    {
        private string PartNumber;
        private int Quantity;
        private string PartDescription;
        private decimal Price;
        private PayrollType payrollType;
        private decimal TotalCost;

        public decimal GetPayableAmount
        {
            get => TotalCost;
        }

        public Invoice(string partNumber, int quantity, string partDescription, decimal price)
        {
            PartNumber = partNumber;
            Quantity = quantity;
            PartDescription = partDescription;
            Price = price;
            PayType = PayrollType.Invoice;
            TotalCost = quantity * price;
        }

        public override string ToString()
        {
            return "Invoice: " + PartNumber + "\n"
                + "Quanity:" + Quantity + "\n"
                + "Part Description" + PartDescription + "\n"
                + "Individual Cost: " + Price.ToString() + "\n"
                + "Invoice Total: " + TotalCost.ToString();
        }

        public PayrollType PayType
        {
            set { payrollType = value; }
            get { return payrollType; }
        }
    }
}
