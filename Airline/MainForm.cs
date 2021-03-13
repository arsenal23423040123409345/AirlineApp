using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
        public partial class MainForm : Form
        {
                public MainForm()
                {
                        InitializeComponent();
                        IsMdiContainer = true;
                }

        private void addNewFlightInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FlightInfo flight = new FlightInfo();
                flight.MdiParent = this;
                IsMdiContainer = true;
                flight.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Customer customer = new Customer();
                customer.MdiParent = this;
                IsMdiContainer = true;
                customer.Show();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
                SearchCustomer searchCustomer = new SearchCustomer();
                searchCustomer.MdiParent = this;
                IsMdiContainer = true;
                searchCustomer.Show();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
                TicketReservation ticket = new TicketReservation();
                ticket.MdiParent = this;
                IsMdiContainer = true;
                ticket.Show();
        }
    }
}
