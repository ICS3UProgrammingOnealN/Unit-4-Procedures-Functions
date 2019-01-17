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

        private void PrintAddress (string streetaddress, string City, string Province, string PostalCode, string ApartmentNumber)
        {
            MessageBox.Show("your address is " + streetaddress +" "+ City +" "+ Province +" "+ PostalCode +" "+ ApartmentNumber);
        }

        private void PrintAddress(string streetaddress, string City, string Province, string PostalCode)
        {
            MessageBox.Show("your address is " + streetaddress + " " + City + " " + Province +" "+ PostalCode);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            string userApartmentNum, userStreetAddress, userCity, userPostalCode, userProvince;

            // get names from textboxes
            userApartmentNum = this.txtApartNum.Text;
            userStreetAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            // make the user enter Street Address
            if (userStreetAddress == "")
            {
                MessageBox.Show("please enter your street address");
            }
            else if (userCity == "")
            {
                MessageBox.Show("please enter your city");
            }
            else if (userPostalCode == "")
            {
                MessageBox.Show("please enter your postal code");
            }
            else if (userProvince == "")
            {
                MessageBox.Show("please enter your province");
            }
            // if user does not enter an apartment number, Call the procedure that accepts only four strings
            else if (userApartmentNum == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            // if user enters an apartment number, Call the procedure that accepts five string
            else
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode, userApartmentNum);
            }
            
        }
    }
}
