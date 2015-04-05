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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string name = "";
        private int noOfTic = 0;
        private int totalPrice = 0;
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && noOfTicTextBox.Text != "")
            {
                name = nameTextBox.Text;
                noOfTic = Convert.ToInt32(noOfTicTextBox.Text);
                totalPrice = noOfTic*10;
                nameTextBox.Text = "";
                noOfTicTextBox.Text = "";
            }
            MessageBox.Show(name+", Please provide "+ totalPrice + " Tk for " +noOfTic+ " Ticket.");
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && noOfTicTextBox.Text != "")
            {
                name = nameTextBox.Text;
                noOfTic = Convert.ToInt32(noOfTicTextBox.Text);
                totalPrice = noOfTic*10;
                nameTextBox.Text = "";
                noOfTicTextBox.Text = "";
            }

            MessageBox.Show("Name : "+name+ "\nNumber Of Ticket : "+noOfTic+ "\nTotal Price : "+totalPrice);
        }
    }
}
