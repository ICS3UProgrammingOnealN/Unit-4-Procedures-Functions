using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverCtoTtoFOnealN
{
    public partial class frmConvertCtoF : Form
    {
        public frmConvertCtoF()
        {
            InitializeComponent();
        }

        public double ConvertCtoF(double Celsius)
        {
            // declare variable
            double far = 0;

            // convert from farinheight to celsius 
            far = Celsius * (9) / (double)(5) + 32;

            return far;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // declare locla variables
            double userCelsius;

            // convert from string to a double 
            userCelsius = double.Parse(txtCelsius.Text);

            // calling the function
            userCelsius = ConvertCtoF(userCelsius);

            // convert to string 
            lblAnswer.Text = string.Format("{0:0.00}", userCelsius) + "far";

        }

        private void frmConvertCtoF_Load(object sender, EventArgs e)
        {

        }
    }
}
