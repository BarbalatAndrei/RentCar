using RentCar.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class FormCustomer : Form
    {

        public List<Customer> customers = new CustomerList().GetCustomers();

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;
            for (int i = 0; i < customers.Count; i++)
            {
                listView.Items.Add(customers[0].ToString());
                listView.Items[i].SubItems.Add(customers[i].id.ToString());
                listView.Items[i].SubItems.Add(customers[i].firstName.ToString());
                listView.Items[i].SubItems.Add(customers[i].lastName.ToString());
                listView.Items[i].SubItems.Add(customers[i].phoneNumber.ToString());
                listView.Items[i].SubItems.Add(customers[i].address.ToString());
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
