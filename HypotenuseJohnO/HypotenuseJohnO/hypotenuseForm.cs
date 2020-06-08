using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypotenuseJohnO
{
    public partial class frmHypotenuse : Form
    {
        public frmHypotenuse()
        {
            InitializeComponent();
            // hide the hypotenuse label
            lblHypotenuse.Hide();
        }

        private void frmHypotenuse_Load(object sender, EventArgs e)
        {

        }
        private double CalculateHypotenuse(double sideA, double sideB)
        {
            // declare variables
            double hypotenuse;

            // calculate the hypotenuse
            hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return hypotenuse;
        }
        private void btnCalculateHypotenuse_Click(object sender, EventArgs e)
        {
            // declare variables
            double userB, userA, userHypotenuse;

            // get the value from the user of A and B
            userA = Convert.ToDouble(this.txtAdjacent.Text);
            userB = Convert.ToDouble(this.txtOpposite.Text);

            // show the hypotenuse label
            lblHypotenuse.Show();

            // call the function to return the hypotenuse
            userHypotenuse = CalculateHypotenuse(userA, userB);

            // Display the hypotenuse
            this.lblHypotenuse.Text = "The hypotenuse of the right angle is:" + userHypotenuse;
        }
    }
}
