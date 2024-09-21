namespace BookstoreApp.UI
{
    partial class NewCustomersForm
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
            btnSave = new Button();
            btnCancel = new Button();
            this.emailTextBox = new TextBox();
            label3 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(361, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(145, 32);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(145, 32);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new Point(195, 112);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new Size(311, 27);
            this.emailTextBox.TabIndex = 13;
            this.emailTextBox.Text = "Add Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(195, 39);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(311, 27);
            nameTextBox.TabIndex = 9;
            nameTextBox.Text = "Add Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 8;
            label1.Text = "First Name:";
            // 
            // NewCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 248);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(this.emailTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "NewCustomersForm";
            Text = "Bookstore Manager: New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox3;
        private Label label3;
        private TextBox emailTextBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
    }
}