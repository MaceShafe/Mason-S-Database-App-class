    namespace BookstoreApp.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsLabel_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new();
            productForm.StartPosition = FormStartPosition.CenterParent;
            productForm.ShowDialog();
        }

        private void productsLabel_MouseHover(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Blue;
        }

        private void productsLabel_MouseLeave(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Black;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            CustomersForm customerForm = new();
            customerForm.StartPosition = FormStartPosition.CenterParent;
            customerForm.ShowDialog();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            InvoicesForm invoicesForm = new();
            invoicesForm.StartPosition = FormStartPosition.CenterParent;
            invoicesForm.ShowDialog();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Blue;

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;

        }
    }
}
