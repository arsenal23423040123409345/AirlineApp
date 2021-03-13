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
        public partial class Form1 : Form
        {
                public Form1()
                {
                    InitializeComponent();
                }
                private void button1_Click(object sender, EventArgs e)
                {
                        AirlineDbEntities db = new AirlineDbEntities();
                        if (userText.Text != string.Empty && passText.Text != string.Empty)
                        {
                                var user = db.Admins.Where(a => a.UserName.Equals(userText.Text)).SingleOrDefault();
                                if(user != null)
                                {
                                        if(user.Password.Equals(passText.Text))
                                        {
                                                //MessageBox.Show($"Welcome {userText.Text}!");
                                                MainForm mainForm = new MainForm();
                                                mainForm.Show();
                                        }
                                        else
                                        {
                                                MessageBox.Show("Wrong password...");
                                         }
                                }
                                else
                                {
                                         MessageBox.Show("Wrong username...");
                                 }
                        }
                        else
                        {
                                MessageBox.Show("Please enter username and password...");
                        }
                }
        }
}
