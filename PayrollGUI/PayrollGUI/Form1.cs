using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiveResults_Click(object sender, EventArgs e)
        {
            string name;
            string socialSecurityNumber;
            double payRate;
            double hoursWorked;
            
            name = txtName.Text;
            socialSecurityNumber = txtSSN.Text;
            payRate = Convert.ToDouble(txtHoursPay.Text);
            hoursWorked = Convert.ToDouble(txtHoursWorked.Text);

            double grossPay;
            double fedWithholding;
            double stateWithholding;
            double netPay;
            grossPay = hoursWorked * payRate;
            fedWithholding = grossPay * .15;
            stateWithholding = grossPay * .05;
            netPay = (grossPay - stateWithholding) - fedWithholding;
            lblResults.Text = "Name : " + name + "\nSSN : " + socialSecurityNumber + 
                "\nGross Pay : " + grossPay + "\nFederal withholding tax : " + fedWithholding + 
               "\nState Withholding tax : " + stateWithholding +  "\nNet pay: " + netPay;

        }
    }
}
