namespace BookstoreApp.UI
{
    partial class CustomersForm
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
            btnDelete = new Button();
            customerListBox = new ListBox();
            btnExit = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 84);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // customerListBox
            // 
            customerListBox.FormattingEnabled = true;
            customerListBox.Location = new Point(22, 28);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(501, 384);
            customerListBox.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(543, 361);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(174, 51);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(543, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(174, 84);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 443);
            Controls.Add(btnDelete);
            Controls.Add(customerListBox);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Name = "CustomersForm";
            Text = "Bookstore Manager: Customers";
            Load += CustomersForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private ListBox customerListBox;
        private Button btnExit;
        private Button btnAdd;
    }
}