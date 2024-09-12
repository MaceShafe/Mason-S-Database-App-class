using BookstoreApp.DataAccess;
using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreApp.UI
{


    public partial class CustomersForm : Form
    {

        private List<Customer> customer = null!;

        public CustomersForm()
        {
            InitializeComponent();
        }


        private void CustomersForm_Load_1(object sender, EventArgs e)
        {


            customer = CustomersDatabase.GetCustomers();

            updateCustomerList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            NewCustomersForm newCustomersForm = new();
            newCustomersForm.StartPosition = FormStartPosition.CenterParent;

            customer.Add(newCustomersForm.GetNewCustomer());
            CustomersDatabase.SaveCustomers(customer);
            updateCustomerList();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            Customer selectedCustomer = customerListBox.SelectedItem as Customer;

            if (selectedCustomer != null)
            {
                DialogResult result = MessageBox.Show(
                                        $"Are you sure you want to delete {selectedCustomer.FirstName}?",
                                        "Confirm Delete",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    customer.Remove(selectedCustomer);
                    CustomersDatabase.SaveCustomers(customer);
                    updateCustomerList();
                }
            }
            else
            {
                MessageBox.Show("No customer selected!", "Select a customer to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void updateCustomerList()
        {
            customerListBox.Items.Clear();

            foreach (Customer customer in customer)
            {
                customerListBox.Items.Add(customer);
            }
        }


    }
}
