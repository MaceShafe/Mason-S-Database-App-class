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
        private bool readOnly = true;

        public ProductDetailsForm()
        {


            InitializeComponent();
        }

        public ProductDetailsForm(ProductsDatabase productsDatabase, Product currentProduct) : this()
        {
            this.database = productsDatabase;
            if (currentProduct != null)
            {
                this.currentProduct = currentProduct;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!readOnly)
            {
                currentProduct.Price = Convert.ToDecimal(PriceTextBox.Text);
                currentProduct.Description = DescriptionTextBox.Text;   
                currentProduct.OnHandQuantity=Convert.ToInt32(OnHandTextBox.Text);

                database.UpdateProduct(currentProduct);
            }
            this.Close();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {

            if (currentProduct != null)
            {
                DisplayProduct();
            }
            else
            {

            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentProduct = database.GetProduct(SKUTextBox.Text);

            if (currentProduct != null)
            {
                DisplayProduct();

            }
            else
            {
                MessageBox.Show("Product Not Found!",
                    "Product Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                                   $"Are you sure you want to delete {currentProduct.Description}?",
                                   "Confirm Delete",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                database.DeleteProduct(currentProduct);
                this.Close();
            }
        }


        private void DisplayProduct()
        {
            SKUTextBox.Text = currentProduct.SKU;
            DescriptionTextBox.Text = currentProduct.Description;
            PriceTextBox.Text = currentProduct.Price.ToString("c");
            OnHandTextBox.Text = currentProduct.OnHandQuantity.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            readOnly = !readOnly;

            DescriptionTextBox.ReadOnly = readOnly;
            OnHandTextBox.ReadOnly = readOnly;
            PriceTextBox.ReadOnly = readOnly;

            if (readOnly)
            {
                btnEdit.Text = "Edit";
                btnExit.Text = "Exit";
            }
            else
            {
                btnEdit.Text = "Cancel";
                btnExit.Text = "Save";
            }
        }
    }
}
