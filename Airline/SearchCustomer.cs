using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Airline
{
        public partial class SearchCustomer : Form
        {
                Thread th;
                public SearchCustomer()
                {
                        InitializeComponent();
                }

                private void SearchCustomer_Load(object sender, EventArgs e)
                {       
                        AirlineDbEntities db = new AirlineDbEntities();     //creating connection
                        var items = db.CustomerDetails.ToList();             //collecting db data in variable

                        dataGridView1.DataSource = items;                    //show data in datagridview
                }

                private void textBox1_TextChanged(object sender, EventArgs e)       //search in grid by keyword
                {
                        AirlineDbEntities db = new AirlineDbEntities();
                        var items = db.CustomerDetails.Where(a => a.Name.Equals(textBox1.Text)).ToList();             //condition to search

                        dataGridView1.DataSource = items;
                }

                private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                        th = new Thread(openNewForm);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        this.Close();
                }

                private void openNewForm(object obj)
                {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        Application.Run(new Customer(id));
                }
        }
}
