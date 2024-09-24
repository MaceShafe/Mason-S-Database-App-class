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
    public partial class ProductsForm : Form
    {
        private List<Product> products = null!;
        private readonly ProductsDatabase db = new();


        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            products = db.GetProducts();

            updateProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewProductForm newProductsForm = new();
            newProductsForm.StartPosition = FormStartPosition.CenterParent;

            Product newProduct = newProductsForm.GetNewProduct();

            products.Add(newProduct);
            db.SaveProducts(newProduct);
            updateProductList();

            //newProductsForm.ShowDialog();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Product selectedProduct = productsListBox.SelectedItem as Product;

            if (selectedProduct != null)
            {

                string SKU = selectedProduct.ToString();

                ProductDetailsForm productDetailsForm = new ProductDetailsForm();


                productDetailsForm.StartPosition = FormStartPosition.CenterParent;
                productDetailsForm.ShowDialog();

            }
            else {
                DialogResult result = MessageBox.Show("Select an object");
                    }


        }

            private void btnDelete_Click(object sender, EventArgs e)
        {

            Product selectedProduct = productsListBox.SelectedItem as Product;

            if (selectedProduct != null)
            {
                DialogResult result = MessageBox.Show(
                                        $"Are you sure you want to delete {selectedProduct.Description}?",
                                        "Confirm Delete",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    products.Remove(selectedProduct);
                    db.SaveProducts(selectedProduct);
                    updateProductList();
                }
            }
            else
            {
                MessageBox.Show("No product selected!", "Select a Product to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void updateProductList()
        {
            productsListBox.Items.Clear();

            foreach (Product product in products)
            {
                productsListBox.Items.Add(product);
            }
        }


    }
}
