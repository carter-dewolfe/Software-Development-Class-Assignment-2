using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Project01
{
    class RetailItem
    {
        private string description;
        private int unitsOnHand;
        private decimal price;

        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int UnitsOnHand
        {
            get { return unitsOnHand; }
            set
            {
                if (value >= 0)
                    unitsOnHand = value;
                else
                    throw new Exception("Units cannot be negative");
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new Exception("Price must be greater than zero");
            }
        }

        public override string ToString()
        {
            return "Description: " + description + ", Units on Hand: " + unitsOnHand + ", Price: " + price.ToString("c");
        }
    }
}
