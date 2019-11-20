using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double total;
            double avg;

            total = Convert.ToDouble(txtEntry1.Text) + Convert.ToDouble(txtEntry2.Text) +
            Convert.ToDouble(txtEntry3.Text) + Convert.ToDouble(txtEntry4.Text) +
            Convert.ToDouble(txtEntry5.Text);

            avg = total / 5;

            lblResults.Text = "Average score is : " + avg;
        }
    }
}
