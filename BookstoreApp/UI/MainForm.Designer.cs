namespace BookstoreApp.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            productsLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(productsLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 405);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(18, 321);
            label2.Name = "label2";
            label2.Size = new Size(340, 28);
            label2.TabIndex = 2;
            label2.Text = "Manage the catolouge of products";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            productsLabel.Location = new Point(3, 232);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(316, 89);
            productsLabel.TabIndex = 1;
            productsLabel.Text = "Products";
            productsLabel.Click += productsLabel_Click;
            productsLabel.MouseLeave += productsLabel_MouseLeave;
            productsLabel.MouseHover += productsLabel_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 226);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(480, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 402);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(22, 321);
            label3.Name = "label3";
            label3.Size = new Size(289, 28);
            label3.TabIndex = 2;
            label3.Text = "Manage the list of customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label4.Location = new Point(3, 232);
            label4.Name = "label4";
            label4.Size = new Size(370, 89);
            label4.TabIndex = 1;
            label4.Text = "Customers";
            label4.Click += label4_Click;
            label4.MouseLeave += label4_MouseLeave;
            label4.MouseHover += label4_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDark;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(429, 226);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(930, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 402);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 321);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 2;
            label1.Text = "See the complete list of invoices";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label5.Location = new Point(3, 232);
            label5.Name = "label5";
            label5.Size = new Size(395, 89);
            label5.TabIndex = 1;
            label5.Text = "All Invoices";
            label5.Click += label5_Click;
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseHover += label5_MouseHover;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = SystemColors.ControlDark;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(429, 226);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 459);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Bookstore Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label productsLabel;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox3;
    }
}
