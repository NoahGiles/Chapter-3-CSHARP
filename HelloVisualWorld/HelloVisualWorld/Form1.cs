using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualWorld
{
    public partial class HelloVisualWorld : Form
    {
        public HelloVisualWorld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "وداعا";
            buttonResult.Text = "انقر فوق لي";
        }

        private void ButtonGoodbye_Click(object sender, EventArgs e)
        {
            helloLabel.Visible = false;
            ButtonGoodbye.Text = "وداعا";
        }
    }
}
