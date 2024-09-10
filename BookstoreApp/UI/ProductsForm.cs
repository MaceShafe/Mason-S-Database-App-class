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
        private List<Products> products = null!;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            products = ProductDatabase.GetProducts();

            updateProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewProductForm newProductsForm = new();
            newProductsForm.StartPosition = FormStartPosition.CenterParent;

            products.Add(newProductsForm.GetNewProduct());
            ProductDatabase.SaveProducts(products);
            updateProductList();

            //newProductsForm.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Products selectedProduct = productsListBox.SelectedItem as Products;

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
                    ProductDatabase.SaveProducts(products);
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

            foreach (Products product in products)
            {
                productsListBox.Items.Add(product);
            }
        }
    }
}
