using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class TicketPurchase : Form
    {

        private string customerName;
        private double noofTicket;
        private double totalPrice;
        public TicketPurchase()
        {
            InitializeComponent();
        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            noofTicket = Convert.ToDouble(noofTicketTextBox.Text);

            totalPrice = noofTicket*10;

            MessageBox.Show("Total Price is " + totalPrice);
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;

            noofTicket = Convert.ToDouble(noofTicketTextBox.Text);

            totalPrice = noofTicket * 10;

            MessageBox.Show("Customer Name = " + customerName + "\n" + "Unit Price = 10" + "\n" + "Number of Ticket = " +
                            noofTicket + "\n" + "Total Price = " + totalPrice);

        }

       
    }
}
