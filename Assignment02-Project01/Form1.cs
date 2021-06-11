using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RetailItem item1 = new RetailItem("Jacket", 12, 59.95M);
            RetailItem item2 = new RetailItem("Jeans", 40, 34.95M);
            RetailItem item3 = new RetailItem("Shirt", 20, 24.95M);

            listBox1.Items.Add(item1.ToString());
            listBox1.Items.Add(item2.ToString());
            listBox1.Items.Add(item3.ToString());
        }
    }
}
