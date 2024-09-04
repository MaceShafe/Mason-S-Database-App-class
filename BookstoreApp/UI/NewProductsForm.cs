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
    public partial class NewProductForm : Form
    {

        private Product product = null!;

        public NewProductForm()
        {
            InitializeComponent();
        }

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product = new()
            {
                SKU = textBox1.Text,
                Description = textBox2.Text,
                Price = Convert.ToDecimal(textBox3.Text)
            };
            this.Close();
        }
    }
}
