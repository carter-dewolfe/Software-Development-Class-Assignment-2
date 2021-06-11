using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Project02
{
    class Person
    {
        private string name;
        private string address;
        private string telephoneNumber;

        public Person(string name, string address, string telephoneNumber)
        {
            Name = name;
            Address = address;
            TelephoneNumber = telephoneNumber;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + " Address: " + address + ", Telephone Number: " + telephoneNumber;
        }
    }
}
