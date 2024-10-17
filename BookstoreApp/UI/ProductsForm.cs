using BookstoreApp.DataAccess;
using BookstoreApp.Models;

namespace BookstoreApp.UI
{
    public partial class ProductsForm : Form
    {
        private List<Product> products = null!;
        private IProductsDatabase database;
        private bool useAdoNet = false;

        public ProductsForm()
        {
            this.database = new ProductsDatabaseEF();
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

            updateProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewProductForm newProductsForm = new();
            newProductsForm.StartPosition = FormStartPosition.CenterParent;

            Product newProduct = newProductsForm.GetNewProduct();

            try {
                database.AddProduct(newProduct);

                products.Add(newProduct);
                updateProductList();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message,
                        "Unable to add product",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show(ex.Message,
                    "Unable to add product",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            //newProductsForm.ShowDialog();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Product product = productsListBox.SelectedItem as Product;

            ProductDetailsForm productDetailsForm = new ProductDetailsForm(database, product);


            productDetailsForm.StartPosition = FormStartPosition.CenterParent;
            productDetailsForm.ShowDialog();

            updateProductList();


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

                    try
                    {
                        products.Remove(selectedProduct);
                        database.DeleteProduct(selectedProduct);
                        updateProductList();
                    }
                    catch (Exception ex) 
                    {
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show(ex.InnerException.Message,
                                "Unable to delete product",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(ex.Message,
                            "Unable to delete product",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
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
            products = database.GetProducts();


            productsListBox.Items.Clear();

            foreach (Product product in products)
            {
                productsListBox.Items.Add(product);
            }
        }

        private void checkBoxADO_CheckedChanged(object sender, EventArgs e)
        {
            this.useAdoNet = checkBoxADO.Checked;

            if (useAdoNet)
            {
                database = new ProductsDatabaseADO();
            }
            else
            {
                database = new ProductsDatabaseEF();
            }

            updateProductList();
        }
    }
}
