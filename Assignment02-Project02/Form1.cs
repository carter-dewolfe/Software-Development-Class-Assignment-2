using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person p1 = new Person("James Anderson", "123 Mockingbird Ln", "701-921-9350");
            Person p2 = new Person("John Doe", "245 Rocking Rd", "781-632-2872");

            Customer c1 = new Customer("Haley Smith", "420 Elm St", "604-935-7712", 101, true);
            Customer c2 = new Customer("Mary Keller", "68 Seaside St", "986-453-0392", 194, false);

            PreferredCustomer pc1 = new PreferredCustomer("Sam Johnson", "913 Starstruck Blvd", "901-467-7201", 261, false, 1808.0M);
            PreferredCustomer pc2 = new PreferredCustomer("Michael Williams", "89 Backstreet Blvd", "373-897-0025", 111, true, 2503.0M);

            listBox1.Items.Add(p1.ToString());
            listBox1.Items.Add(p2.ToString());
            listBox1.Items.Add(c1.ToString());
            listBox1.Items.Add(p2.ToString());
            listBox1.Items.Add(pc1.ToString());
            listBox1.Items.Add(pc2.ToString());
        }
    }
}
