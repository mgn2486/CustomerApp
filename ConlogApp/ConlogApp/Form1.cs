using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConlogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var customerService = new CustomerService();
            var listOfCustomers = customerService.GetAllCustomers();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Date Of Birth", typeof(DateTime));

            if (listOfCustomers != null)
            {
                foreach (var customer in listOfCustomers)
                {
                    dt.Rows.Add(customer.Id, customer.Name, customer.DateOfBirth);
                }                
            }

            CustomerDataGridView.DataSource = dt;
        }

    }
}
