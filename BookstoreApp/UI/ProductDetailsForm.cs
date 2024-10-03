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
        private Product currentProduct;
        private readonly ProductsDatabase database;
        
        public ProductDetailsForm()
        {


            InitializeComponent();
        }

        public ProductDetailsForm(ProductsDatabase productsDatabase, Product currentProduct) : this()
        {
            this.database= productsDatabase;
            if (currentProduct != null)
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

            if (currentProduct != null)
            {
                SKUTextBox.Text = currentProduct.SKU;
                DescriptionTextBox.Text = currentProduct.Description;
                PriceTextBox.Text = currentProduct.Price.ToString("c");
                OnHandTextBox.Text = currentProduct.OnHandQuantity.ToString();
            }
            else
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            


        }
    }
}
