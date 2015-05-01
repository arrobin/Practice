using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformation : Form
    {
        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fathersNameTextBox.Text;
            motherName = mothersNameTextBox.Text;
            address = addressTextBox.Text;

            
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            fathersNameTextBox.Text = "";
            mothersNameTextBox.Text = "";
            addressTextBox.Text = "";

            MessageBox.Show("Data Saved");

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name = "+firstName+" "+lastName);
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name = " + fatherName + "\n" + "Mothers's Name = " + motherName);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address = " + address);
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name = " + firstName + " " + lastName + "\n" + "Father's Name = " + fatherName + "\n" + "Mothers's Name = " + motherName + "\n" + "Address = " + address);
        }

       
    }
}
