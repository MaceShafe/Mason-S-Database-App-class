using BookstoreApp.DataAccess;
using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreApp.UI
{
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            List<Customer> customers = CustomersDatabase.GetCustomers();
            List<Invoice> invoices = InvoicesDatabase.GetInvoices();

            var customerInvoices = from invoice in invoices
                                   join customer in customers
                                   on invoice.CustomerID equals customer.Id
                                   select new
                                   {
                                       customer.Name,
                                       invoice.Id,
                                       invoice.InvoiceDate,
                                       invoice.InvoiceTotal
                                   };

            int i = 0;

            foreach (var invoice in customerInvoices)
            {
                if (invoice != null)
                {
                    listView1.Items.Add(invoice.Name);
                    listView1.Items[i].SubItems.Add(invoice.Id.ToString());
                    listView1.Items[i].SubItems.Add(invoice.InvoiceDate.ToString());
                    listView1.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString());
                }

                i += 1;
            }

        }

    }

}

