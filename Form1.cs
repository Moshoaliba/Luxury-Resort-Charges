//Moshoaliba,K-34316345

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charges_in_a_Luxury_Resort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal days = decimal.Parse(txtInput.Text);
            decimal charge_1 = decimal.Parse(txtInput2.Text);
            decimal charge_2 = decimal.Parse(txtInput3.Text);
            decimal charge_3 = decimal.Parse(txtInput4.Text);
            decimal charge_4 = decimal.Parse(txtInput5.Text);


            CalcStayCharges(days);

            CalcMiscCharges(charge_1, charge_2, charge_3, charge_4);

            CalcTotalCharges(days, charge_1, charge_2, charge_3, charge_4);
        }

        private decimal CalcStayCharges(decimal days)
        {
            const decimal Charge_for_stay = 550.00m;
            decimal charge = days * Charge_for_stay;

            listBox1.Items.Add("Stay charges : " + charge.ToString("C"));

            return charge;

        }

        private decimal CalcMiscCharges(decimal charge_1, decimal charge_2 ,decimal charge_3, decimal charge_4)
        {
            decimal total = charge_1 + charge_3 + charge_2 + charge_4;

            listBox1.Items.Add("Miscellaneuos charges : " + total.ToString("C"));

            return total;
        }

        private decimal CalcTotalCharges(decimal days ,decimal charge_1, decimal charge_2, decimal charge_3, decimal charge_4)
        {
            const decimal Charge_for_stay = 550.00m;
            decimal charge = days * Charge_for_stay;

            decimal all_charges = charge_1 + charge_3 + charge_2 + charge_4 + charge;

            listBox1.Items.Add("Total Bill : " + all_charges.ToString("C"));

            return all_charges;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
