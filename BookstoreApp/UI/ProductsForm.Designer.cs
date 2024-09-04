namespace BookstoreApp.UI
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnExit = new Button();
            productsListBox = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(533, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 84);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(533, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(174, 51);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // productsListBox
            // 
            productsListBox.FormattingEnabled = true;
            productsListBox.Location = new Point(12, 12);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(501, 384);
            productsListBox.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(533, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 84);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(btnDelete);
            Controls.Add(productsListBox);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Name = "ProductsForm";
            Text = "Bookstore Manager: Products";
            Load += ProductsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnExit;
        private ListBox productsListBox;
        private Button btnDelete;
    }
}