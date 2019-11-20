using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            const int CAR_RENTAL_PER_DAY = 20;
            const double CAR_RENTAL_PER_MILE = .25;
            int milesTraveled;
            int daysTraveled;
            double carRentalTotal;

            milesTraveled = Convert.ToInt32(txtMiles.Text);
            daysTraveled = Convert.ToInt32(txtDays.Text);
            carRentalTotal = (CAR_RENTAL_PER_DAY * daysTraveled) + (CAR_RENTAL_PER_MILE * milesTraveled);

            lblFeeOutput.Text = "Given " + daysTraveled + " days and " + milesTraveled + " miles, your "
            + "fee is $" + carRentalTotal + ".";
        }
    }
}
