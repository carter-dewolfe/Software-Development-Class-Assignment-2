using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Project02
{
    class Customer : Person
    {
        private int customerNumber;
        private bool mailingList;

        public Customer(string name, string address, string telephoneNumber, int customerNumber, bool mailingList) 
            : base(name, address, telephoneNumber)
        {
            CustomerNumber = customerNumber;
            MailingList = mailingList;
        }

        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value < 0) // validation
                {
                    throw new Exception("Customer number must be greater than zero");
                }

                customerNumber = value;
            }
        }

        public bool MailingList
        {
            get { return mailingList; }
            set
            {
                if (value == true)
                    mailingList = value;
                else if (value == false)
                    mailingList = value;
                else
                    throw new Exception("Must be either true or false");
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Customer Number: " + customerNumber + ", Mailing List: " + mailingList;
        }
    }
}
