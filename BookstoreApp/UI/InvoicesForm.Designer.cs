namespace BookstoreApp.UI
{
    partial class InvoicesForm
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
            listView1 = new ListView();
            btn_exit = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(640, 356);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F);
            btn_exit.Location = new Point(518, 384);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(134, 54);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Customer";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Invoice ID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Invoice Date";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Invoice Total";
            columnHeader4.Width = 120;
            // 
            // InvoicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(btn_exit);
            Controls.Add(listView1);
            Name = "InvoicesForm";
            Text = "Form1";
            Load += InvoicesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btn_exit;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}