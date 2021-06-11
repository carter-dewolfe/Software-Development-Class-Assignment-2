using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Assignment02_Project03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PopulationDBEntities dbcontext = new PopulationDBEntities();


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTableData();
        }

        private void ShowTableData()
        {
            dbcontext.Cities.Load();

            var result = from item in dbcontext.Cities.Local
                         orderby item.City1
                         select item;

            dataGridView1.DataSource = result.ToList();
        }

        private void SortPopDescButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            var result = from item in dbcontext.Cities.Local
                         orderby item.Population descending
                         select item;

            dataGridView1.DataSource = result.ToList();
        }

        private void SortPopAscButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            var result = from item in dbcontext.Cities.Local
                         orderby item.Population ascending
                         select item;
            dataGridView1.DataSource = result.ToList();
        }

        private void SortNameButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            var result = from item in dbcontext.Cities.Local
                         orderby item.City1
                         select item;

            dataGridView1.DataSource = result.ToList();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            City myCity = new City();
            
            myCity.Population = Convert.ToDouble(populationTextBox.Text);
            myCity.City1 = cityTextBox.Text;

            dbcontext.Cities.Add(myCity);
            dbcontext.SaveChanges();
            
            ShowTableData();

            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            City result = (from item in dbcontext.Cities.Local
                              where item.City1 == cityTextBox.Text 
                              && item.Population == Convert.ToDouble(populationTextBox.Text)
                              select item).First();

            dbcontext.Cities.Remove(result);
            dbcontext.SaveChanges();
            ShowTableData();

            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            City myCity = new City();
            dbcontext.Cities.Load();

            City result = (from item in dbcontext.Cities.Local
                           where item.City1 == originalCityTextBox.Text
                           && item.Population == Convert.ToDouble(originalPopulationTextBox.Text)
                           select item).First();

            dbcontext.Cities.Remove(result);
            myCity.Population = Convert.ToDouble(populationTextBox.Text);
            myCity.City1 = cityTextBox.Text;
            dbcontext.Cities.Add(myCity);

            dbcontext.SaveChanges();
            ShowTableData();

            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void TotalPopButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            double total = 0;

            var results =
            from item in dbcontext.Cities.Local
            group item by item.Population
            into p
            select new { Population = p.Key, Sum = p.Sum(item => item.Population) };

            foreach (var result in results)
            {
                total += result.Sum;
                
            }

            MessageBox.Show("Total Population: " + total);
        }

        private void AveragePopButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            double total = 0;
            double average = 0;
            int count = 0;

            var results =
            from item in dbcontext.Cities.Local
            group item by item.Population
            into pop
            select new { Population = pop.Key, Sum = pop.Sum(item => item.Population) };

            foreach (var result in results)
            {
                total += result.Sum;
                count++;
            }

            average = total / count;
            MessageBox.Show("Average Population: " + average);
        }

        private void MaxPopButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            double max = 0;

            var result = from item in dbcontext.Cities.Local
                         orderby item.Population descending
                         select item;

            max = result.First().Population;

            MessageBox.Show("Max Population: " + max);
        }

        private void MinPopButton_Click(object sender, EventArgs e)
        {
            dbcontext.Cities.Load();

            double min = 0;

            var result = from item in dbcontext.Cities.Local
                         orderby item.Population ascending
                         select item;

            min = result.First().Population;

            MessageBox.Show("Max Population: " + min);
        }
    }
}
