using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateVolumeO
{
    public partial class CalculateVolumeForm : Form
    {
        public CalculateVolumeForm()
        {
            InitializeComponent();
            lblAnswer.Hide();
        }
        private double CalculateVolume(double radius, double height)
        {
            // ddclare local variable
            double volume = 0;

            volume = Math.PI * Math.Pow(radius, 2) * height;

            // return the volume to the procedure
            return volume;
        }


        private void btnCalculateVolume_Click(object sender, EventArgs e) 
        {
            double radius, height, UserVolume;

            // convert the string to a double
            radius = double.Parse(txtRadius.Text);
            height = double.Parse(txtHeight.Text);

            // call the procedure 
            UserVolume = CalculateVolume(radius, height);

            lblAnswer.Text = string.Format("(0:0.00)", UserVolume) + "cm";

            // show the answer
            lblAnswer.Show();
        }
    }
}
