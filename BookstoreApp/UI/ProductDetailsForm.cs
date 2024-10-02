using BookstoreApp.DataAccess;
using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreApp.UI
{
    public partial class ProductDetailsForm : Form
    {
//        private readonly CustomersDatabase customersDatabase = new CustomersDatabase();

        private Product currentProduct;
        public ProductDetailsForm()
        {


            InitializeComponent();
        }

        public ProductDetailsForm(Product currentProduct) : this() {
            if(currentProduct==null)
            {
                currentProduct = new()
                {
                    SKU = "NEW-001",
                    Description = "An awesome new product",
                    Price = 50m,
                    OnHandQuantity = 100
                };
            }
            else
            {
                this.currentProduct = currentProduct;

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {


            SKUTextBox.Text = currentProduct.SKU;
            DescriptionTextBox.Text = currentProduct.Description;
            PriceTextBox.Text = currentProduct.Price.ToString("c");
            OnHandTextBox.Text= currentProduct.OnHandQuantity.ToString();

        }
    }
}
