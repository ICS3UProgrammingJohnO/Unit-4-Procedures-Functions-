using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByValueJohnO
{
    public partial class frmPassByValue : Form
    {
        public frmPassByValue()
        {
            InitializeComponent();
        }
        public void CalculateFahrenheit(int celsius)
        {
            // declare local variables
            int celcius;
            double fahrenheit;

            // convert celcius to an integer
            celcius = int.Parse(txtCelsius.Text);

            // Calculate the fahrenheit
            fahrenheit = (double)9 / (double)5 * celsius + 32;

            // display a message box with the calculated fahrenheit
            MessageBox.Show(" The degrees in fahrenheit is: " + fahrenheit + "°");
        }
        private void frmPassByValue_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userCelsius;

            // convert the input celsius from String to int and assign them to their corresponding variables
            userCelsius = Convert.ToInt16(this.txtCelsius.Text);

            // Call the function to calculate the celsius passing the celsius and fahrenheit arguements by value
            this.CalculateFahrenheit(userCelsius);
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
