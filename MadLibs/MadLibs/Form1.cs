using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibs
{
    public partial class godForm : Form
    {
        public godForm()
        {
            InitializeComponent();
        }

        private void btnCreateStory_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtNumber1.Text) - Convert.ToDouble(txtNumber2.Text);

            lblResult.Text = "God smote all of the " + txtColor.Text + " men in the " + txtWordEst.Text +
                " manner possible. He must sacrifice " + num + " " + txtBodyPlural.Text + " within the " +
                txtAnimal.Text + " species. But without the " + txtNoun.Text + ", God has no power whatsoever."
                + "In fact, it is only because of " + txtPluralNoun.Text + " that God remains such a cool guy.";
        }
    }
}
