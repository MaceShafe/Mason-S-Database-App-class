namespace BookstoreApp.UI
{
    partial class ProductDetailsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            SKUTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            PriceTextBox = new TextBox();
            OnHandTextBox = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Unit Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 120);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "On Hand:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(23, 166);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(123, 166);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(350, 166);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SKUTextBox
            // 
            SKUTextBox.Location = new Point(139, 19);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(125, 27);
            SKUTextBox.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(139, 52);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(307, 27);
            DescriptionTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(139, 85);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 9;
            // 
            // OnHandTextBox
            // 
            OnHandTextBox.Location = new Point(139, 118);
            OnHandTextBox.Name = "OnHandTextBox";
            OnHandTextBox.Size = new Size(125, 27);
            OnHandTextBox.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(270, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductDetailsForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(458, 211);
            Controls.Add(btnSearch);
            Controls.Add(OnHandTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(SKUTextBox);
            Controls.Add(btnExit);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductDetailsForm";
            Text = "Add/Modify";
            Load += ProductDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnExit;
        private TextBox SKUTextBox;
        private TextBox DescriptionTextBox;
        private TextBox PriceTextBox;
        private TextBox OnHandTextBox;
        private Button btnSearch;
    }
}