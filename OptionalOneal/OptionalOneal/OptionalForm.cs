using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalOneal
{
    public partial class frmOptional : Form
    {
        public frmOptional()
        {
            InitializeComponent();
        }
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            string userApartmentNum, userStreetAddress, userCity, userPostalCode, UserProvince;

            // get names from textboxes
            userApartmentNum = this.txtApartNum.Text;
            userStreetAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            UserProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            // make the user enter Street Address
            if (userStreetAddress == "")
            {
                MessageBox.Show("please enter your street address");
            }
            if (userCity == "")
            {
                MessageBox.Show("please enter your city");
            }
            //if (user)


            
        }
    }
}
