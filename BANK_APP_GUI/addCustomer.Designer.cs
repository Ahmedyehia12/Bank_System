namespace BANK_APP_GUI
{
    partial class addCustomer
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
            customerName = new TextBox();
            customerPhone = new TextBox();
            customerAddress = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            button6 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.BackColor = SystemColors.Control;
            customerName.Location = new Point(385, 161);
            customerName.Margin = new Padding(3, 2, 3, 2);
            customerName.Name = "customerName";
            customerName.Size = new Size(182, 23);
            customerName.TabIndex = 0;
            // 
            // customerPhone
            // 
            customerPhone.BackColor = SystemColors.Control;
            customerPhone.Location = new Point(385, 202);
            customerPhone.Margin = new Padding(3, 2, 3, 2);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(182, 23);
            customerPhone.TabIndex = 3;
            // 
            // customerAddress
            // 
            customerAddress.BackColor = SystemColors.Control;
            customerAddress.Location = new Point(385, 245);
            customerAddress.Margin = new Padding(3, 2, 3, 2);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(182, 23);
            customerAddress.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(354, 365);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(164, 161);
            label4.Name = "label4";
            label4.Size = new Size(202, 23);
            label4.TabIndex = 13;
            label4.Text = "Enter Customer's Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(164, 199);
            label5.Name = "label5";
            label5.Size = new Size(205, 23);
            label5.TabIndex = 14;
            label5.Text = "Enter Customer's Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(164, 242);
            label6.Name = "label6";
            label6.Size = new Size(218, 23);
            label6.TabIndex = 15;
            label6.Text = "Enter Customer's Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(277, 52);
            label2.Name = "label2";
            label2.Size = new Size(238, 45);
            label2.TabIndex = 16;
            label2.Text = "Add Customer";
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 19;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(733, 412);
            button2.Name = "button2";
            button2.Size = new Size(59, 26);
            button2.TabIndex = 20;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(804, 450);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(customerAddress);
            Controls.Add(customerPhone);
            Controls.Add(customerName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "addCustomer";
            Text = "addCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerName;
        private TextBox customerPhone;
        private TextBox customerAddress;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Button button6;
        private Button button2;
    }
}