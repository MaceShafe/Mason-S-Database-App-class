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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(412, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(312, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "Add Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 169);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 27);
            textBox2.TabIndex = 11;
            textBox2.Text = "Add Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 106);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 10;
            label2.Text = "Last Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 27);
            textBox1.TabIndex = 9;
            textBox1.Text = "Add Text";
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
            ClientSize = new Size(567, 277);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}