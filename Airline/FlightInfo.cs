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
        public partial class FlightInfo : Form
        {
                AirlineDbEntities db;
                public FlightInfo()
                {
                        InitializeComponent();
                        db = new AirlineDbEntities();
                }

                private void button1_Click(object sender, EventArgs e)
                {
                        FlightDetail flightDetail = new FlightDetail();
                        flightDetail.FlightName = flightNameText.Text;
                        flightDetail.Source = sourceText.Text;
                        flightDetail.Destination = destinationText.Text;
                        flightDetail.Departure = departureText.Text;
                        flightDetail.ArrivalTime = arrivalTimeText.Text;
                        flightDetail.FlightClass = flightClassText.Text;
                        flightDetail.FlightCharges = Convert.ToDecimal(flightChargesText.Text);
                        flightDetail.Seats = Convert.ToInt32(seatsText.Text);
                        db.FlightDetails.Add(flightDetail);
                        db.SaveChanges();
                        MessageBox.Show("Added flight!");
                }
        }
}
