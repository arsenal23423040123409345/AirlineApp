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
        public partial class TicketReservation : Form
        {
                AirlineDbEntities db;
                public TicketReservation()
                {
                        InitializeComponent();
                        db = new AirlineDbEntities();
                        BindingSource();
                        BindDestination();
                }

                private void BindingSource()
                {
                        var items = db.FlightDetails.ToList();
                        sourceCombo.DataSource = items;
                        sourceCombo.DisplayMember = "Source";
                 }

                private void BindDestination()
                {
                        var items = db.FlightDetails.ToList(); 
                        destinationCombo.DataSource = items;
                        destinationCombo.DisplayMember = "Destination";
                }

                private void button1_Click(object sender, EventArgs e)
                {
                        if(sourceCombo.Text != destinationCombo.Text)   // validating flight
                        {
                                dataGridView1.DataSource = db.FlightDetails.Where(a => a.Source.Equals(sourceCombo.Text) 
                                                                                                                        && a.Destination.Equals(destinationCombo.Text)).ToList(); // using ToList() to execute code immediately
                        }
                }

                private void button3_Click(object sender, EventArgs e)
                {
                        int itemId = Convert.ToInt32(customerIdText.Text);
                        var item = db.CustomerDetails.Where(a=>a.Id == itemId).FirstOrDefault();
                        customerNameText.Text = item.Name;
                        fatherNameText.Text = item.FatherName;
                        birthDateText.Value = (DateTime)item.BirthDate;
                        emailText.Text = item.Email;
                        phoneText.Text = item.Phone;
                        addressText.Text = item.Address;

                }

                private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        var flightId = dataGridView1.SelectedRows[0].Cells[0].Value;
                        flightIdText.Text = flightId.ToString();
                }

                private void button2_Click(object sender, EventArgs e)
                {
                        if(Convert.ToInt32(seatText.Text) < 120)                //let 120 be the maximum number of seats on the aircraft
                        {
                                if(availableSeat() == true)
                                {
                                    Booking booking = new Booking();
                                    booking.CustomerId = Convert.ToInt32(customerIdText.Text);
                                    booking.SeatNo = Convert.ToInt32(seatText.Text);
                                    booking.DateOfJourney = dateOfJourneyText.Value;
                                    booking.FlightId = Convert.ToInt32(flightIdText.Text);
                                    db.Bookings.Add(booking);
                                    db.SaveChanges();
                                    MessageBox.Show("Flight booked!");
                                }
                                else
                                {
                                        MessageBox.Show("Sorry! This seat is already booked");
                                 }
                        }
                        else
                        {
                                MessageBox.Show("There's only 120 seats on the aircraft!");
                        }
                }

                private bool availableSeat()
                {
                        int flightId = Convert.ToInt32(flightIdText.Text);
                        int seatNo = Convert.ToInt32(seatText.Text);
                        DateTime dateOfJourney = dateOfJourneyText.Value;
                        var item = db.Bookings.Where(a => a.FlightId == flightId  && a.SeatNo == seatNo).FirstOrDefault();

                        if(item != null)
                        {
                                string existsDate = Convert.ToDateTime(item.DateOfJourney).ToString("dd/MM/YYYY");
                                if(existsDate == dateOfJourney.ToString("dd/MM/YYYY"))
                                {
                                        return false;
                                }
                                else
                                {
                                        return true;
                                }
                        }
                        else
                        {
                                return true;
                        }
                }


        // all code below created to make booking button disabled till all fields are done
        private void updateButton()
                {
                        button2.Enabled = customerIdText.Text != string.Empty && customerNameText.Text != string.Empty && fatherNameText.Text != string.Empty 
                                && birthDateText.Text != string.Empty && emailText.Text != string.Empty && phoneText.Text != string.Empty
                                && addressText.Text != string.Empty && dateOfJourneyText.Text != string.Empty && flightIdText.Text != string.Empty 
                                && seatText.Text != string.Empty;
                }

                private void customerIdText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void customerNameText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void fatherNameText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void birthDateText_ValueChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void emailText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void phoneText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void addressText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void dateOfJourneyText_ValueChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void flightIdText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }

                private void seatText_TextChanged(object sender, EventArgs e)
                {
                        updateButton();
                }
        }
}
