using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
        public partial class Customer : Form
        {
                Thread th;
                AirlineDbEntities db;
                static int id = 0;

        public Customer([Optional] int? Id)
                {
                        InitializeComponent();
                        if(Id != null)
                        {
                                button1.Visible = false;
                                db = new AirlineDbEntities();
                                CustomerDetail cust = db.CustomerDetails.Where(a=>a.Id == Id).FirstOrDefault();
                                id = cust.Id;
                                nameText.Text = cust.Name;
                                fnameText.Text = cust.FatherName;
                                birthDateText.Value = Convert.ToDateTime(cust.BirthDate);
                                emailText.Text = cust.Email;
                                phoneText.Text = cust.Phone;
                                addressText.Text = cust.Address;
                        }
                        else
                        {
                                button2.Visible = false;
                        }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                        AirlineDbEntities db = new AirlineDbEntities();
                        CustomerDetail customers = new CustomerDetail
                        {
                            Name = nameText.Text,
                            FatherName = fnameText.Text,
                            BirthDate = birthDateText.Value,
                            Email = emailText.Text,
                            Phone = phoneText.Text,
                            Address = addressText.Text
                        };
                        try
                        {
                                db.CustomerDetails.Add(customers);
                                db.SaveChanges();
                                MessageBox.Show("Added customer!");
                        }
                        catch(Exception ex)
                        {
                                throw new ArgumentException("Database insert exception. ", ex);
                        }

                }

                private void button2_Click(object sender, EventArgs e)
                {
                        db = new AirlineDbEntities();
                        CustomerDetail cust = db.CustomerDetails.Where(a => a.Id == id).FirstOrDefault();
                        cust.Name = nameText.Text;
                        cust.FatherName = fnameText.Text;
                        cust.BirthDate = birthDateText.Value;
                        cust.Email = emailText.Text;
                        cust.Phone = phoneText.Text;
                        cust.Address = addressText.Text;
                        //db.CustomerDetails.Attach(cust);
                        db.SaveChanges();
                        MessageBox.Show("Customer modified!");

                        th = new Thread(openNewForm);                   //close this window, and open new
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Close();
                }

                private void openNewForm(object obj)
                {
                        Application.Run(new SearchCustomer());
                }
    }
}
