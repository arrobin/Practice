using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEntryApp
{
    public partial class NumberEntry : Form
    {
        List<double> numberList = new List<double>();
        
        public NumberEntry()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double inputNumber = Convert.ToDouble(enterNumberTextBox.Text);
            numberList.Add(inputNumber);
            enterNumberTextBox.Text = "";
        }

        private void showNumberButton_Click(object sender, EventArgs e)
        {
            showNumberListBox.Items.Clear();
            double sum = 0;
            foreach (double numbers in numberList)
            {
                showNumberListBox.Items.Add(numbers);
                sum = sum + numbers;
            }

            sumResultTextBox.Text = sum.ToString();
        }
    }
}
