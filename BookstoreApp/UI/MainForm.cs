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
            ProductsForm productsForm = new();
            productsForm.ShowDialog();
        }

        private void productsLabel_MouseHover(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Blue;
        }

        private void productsLabel_MouseLeave(object sender, EventArgs e)
        {
            productsLabel.ForeColor = Color.Black;

        }
    }
}
