using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02_Project04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDataSet.City);

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.InsertQuery(cityTextBox.Text, Convert.ToDouble(populationTextBox.Text));
            this.cityTableAdapter.Fill(this.populationDataSet.City);

            //Clear out textboxes after use
            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.UpdateQuery(cityTextBox.Text, Convert.ToDouble(populationTextBox.Text), originalCityTextBox.Text, Convert.ToDouble(originalPopulationTextBox.Text));
            this.cityTableAdapter.Fill(this.populationDataSet.City);

            //Clear out textboxes after use
            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.DeleteQuery(cityTextBox.Text, Convert.ToDouble(populationTextBox.Text));
            this.cityTableAdapter.Fill(this.populationDataSet.City);

            //Clear out textboxes after use
            cityTextBox.Clear();
            populationTextBox.Clear();
            originalCityTextBox.Clear();
            originalPopulationTextBox.Clear();
        }

        private void TotalPopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population: " + this.cityTableAdapter.SumQuery());
        }

        private void AveragePopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population: " + this.cityTableAdapter.AverageQuery());
        }

        private void MaxPopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Max Population: " + this.cityTableAdapter.MaxPopulationQuery());
        }

        private void MinPopButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Min Population: " + this.cityTableAdapter.MinPopulationQuery());
        }

        private void SortPopDescButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByDescendingOrder(this.populationDataSet.City);
        }

        private void SortPopAscButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByAscendingOrder(this.populationDataSet.City);
        }

        private void SortNameButton_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityName(this.populationDataSet.City);
        }
    }
}
