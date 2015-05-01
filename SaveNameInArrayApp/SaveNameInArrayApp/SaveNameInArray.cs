using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameInArrayApp
{
    public partial class SaveNameInArray : Form
    {
        string [] namesArray  = new string [5] ;
        private int i = 0;
        public SaveNameInArray()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (i<5)
            {
                string name = enterNameTextBox.Text;
                namesArray[i] = name;
                
                int total = i + 1;
                totalTextBox.Text = total.ToString();
                i++;
            }
            else
            {
                MessageBox.Show("You Can Add Maximum 5 Name ");
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                saveNameListBox.Items.Add(namesArray[i]);
            }
        }
    }
}
