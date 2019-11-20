using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertSalary_Click(object sender, EventArgs e)
        {
            const double PROJECTED_RAISE = .04;
            double salary;
            double salaryChanged;

            salary = Convert.ToDouble(txtSalary.Text);
            salaryChanged = salary + salary * PROJECTED_RAISE;

            lblRaiseText.Text = "Salary of $" + salary + " goes into $" + salaryChanged + " with a 4% raise.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
