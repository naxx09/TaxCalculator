using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distanceCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculBtn_Click(object sender, EventArgs e)
        {
            double spend = 0;
            double tax = 0;
            
            if(double.TryParse(SpendTb.Text, out spend))
            {
                if (double.TryParse(PerTb.Text, out tax))
                {
                    double totalTax = spend * (tax / 100);

                    double totalCost = totalTax + spend;

                    TotalTaxTb.Text = Convert.ToString(totalTax);
                    TotalCostTb.Text = Convert.ToString(totalCost);
                }
                else
                {
                    MessageBox.Show("The value of tax is not valid.");
                    PerTb.Focus();
                }
            }
            else
            {
                MessageBox.Show("The value of spend is not valid.");
                SpendTb.Focus();
            }
            
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SpendTb.Text = string.Empty;
            PerTb.Text = string.Empty;
            TotalTaxTb.Text = string.Empty;
            TotalCostTb.Text = string.Empty;
            SpendTb.Focus();
        }
    }
}
