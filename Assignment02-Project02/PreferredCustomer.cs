using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Project02
{
    class PreferredCustomer : Customer
    {
        private decimal amountSpent;
        private decimal discount;
        private decimal calcAmount;

        public PreferredCustomer(string name, string address, string telephoneNumber, int customerNumber, bool mailingList, 
            decimal amountSpent): base(name, address, telephoneNumber, customerNumber, mailingList)
        {
            AmountSpent = amountSpent;
            Discount = discount;
            CalcAmount = calcAmount;
        }
         public decimal AmountSpent
        {
            get { return amountSpent; }
            set
            {
                if (value < 0) // validation
                {
                    throw new Exception("Amount must be greater than zero");
                }

                amountSpent = value;
            }
        }

        public decimal Discount
        {
            get { return discount; }
            set
            {
                if (amountSpent < 500)
                    discount = 0;
                else if (amountSpent >= 500 && amountSpent < 1000)
                    discount = .05M;
                else if (amountSpent >= 1000 && amountSpent < 1500)
                    discount = .06M;
                else if (amountSpent >= 1500 && amountSpent < 2000)
                    discount = .07M;
                else
                    discount = .1M;
            }
        }

        public decimal CalcAmount
        {
            get { return calcAmount; }
            set
            {
                calcAmount = amountSpent - (amountSpent * discount);
            }
        }

        public override string ToString()
        {
            return base.ToString() +", Amount Spent Before Discount:" + amountSpent.ToString("c") + ", Discount: " + discount.ToString("p") + ", Amount Owed; " + calcAmount.ToString("c");
        }
    }
}
