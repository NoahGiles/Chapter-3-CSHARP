using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class EggsInteractive : Form
    {
        public EggsInteractive()
        {
            InitializeComponent();
        }

        private void btnConvertEggs_Click(object sender, EventArgs e)
        {
            int eggsTotal;
            int numDozen;
            int numEggsRemaining;
            const int DOZEN_EGGS = 12;
            
            eggsTotal = Convert.ToInt32(txtEggs1.Text) + Convert.ToInt32(txtEggs2.Text) + 
            Convert.ToInt32(txtEggs3.Text) + Convert.ToInt32(txtEggs4.Text) + 
            Convert.ToInt32(txtEggs5.Text);

            numDozen = eggsTotal / DOZEN_EGGS;
            numEggsRemaining = eggsTotal % DOZEN_EGGS;

            lblResult.Text = eggsTotal + " eggs is " + numDozen + " dozen with " + numEggsRemaining + " left over.";
        }
    }
}
