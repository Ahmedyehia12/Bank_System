namespace BANK_APP_GUI
{
    partial class updateCustomer
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
            customerSSN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            newName = new TextBox();
            label3 = new Label();
            customerAddress = new TextBox();
            label4 = new Label();
            customerPhone = new TextBox();
            button1 = new Button();
            label5 = new Label();
            button6 = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // customerSSN
            // 
            customerSSN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerSSN.Location = new Point(530, 238);
            customerSSN.Name = "customerSSN";
            customerSSN.Size = new Size(238, 30);
            customerSSN.TabIndex = 0;
            customerSSN.TextChanged += customerSSN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(249, 243);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 1;
            label1.Text = "Enter Customer's SSN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(249, 300);
            label2.Name = "label2";
            label2.Size = new Size(237, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer's new name:";
            // 
            // newName
            // 
            newName.Location = new Point(530, 300);
            newName.Name = "newName";
            newName.Size = new Size(238, 30);
            newName.TabIndex = 3;
            newName.TextChanged += newName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(249, 358);
            label3.Name = "label3";
            label3.Size = new Size(257, 23);
            label3.TabIndex = 4;
            label3.Text = "Enter Customer's new Address:";
            // 
            // customerAddress
            // 
            customerAddress.Location = new Point(544, 356);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(238, 30);
            customerAddress.TabIndex = 5;
            customerAddress.TextChanged += customerAddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(249, 419);
            label4.Name = "label4";
            label4.Size = new Size(242, 23);
            label4.TabIndex = 6;
            label4.Text = "Enter Customer's new Phone:";
            // 
            // customerPhone
            // 
            customerPhone.Location = new Point(530, 419);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(238, 30);
            customerPhone.TabIndex = 7;
            customerPhone.TextChanged += customerPhone_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(444, 542);
            button1.Name = "button1";
            button1.Size = new Size(178, 64);
            button1.TabIndex = 8;
            button1.Text = "Update Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(340, 93);
            label5.Name = "label5";
            label5.Size = new Size(371, 58);
            label5.TabIndex = 9;
            label5.Text = "Update Customer";
            // 
            // button6
            // 
            button6.Location = new Point(16, 18);
            button6.Margin = new Padding(3, 5, 3, 5);
            button6.Name = "button6";
            button6.Size = new Size(75, 40);
            button6.TabIndex = 12;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(465, 626);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 23);
            errorLabel.TabIndex = 13;
            // 
            // updateCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1060, 659);
            Controls.Add(errorLabel);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(customerPhone);
            Controls.Add(label4);
            Controls.Add(customerAddress);
            Controls.Add(label3);
            Controls.Add(newName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerSSN);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Maroon;
            Name = "updateCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerSSN;
        private Label label1;
        private Label label2;
        private TextBox newName;
        private Label label3;
        private TextBox customerAddress;
        private Label label4;
        private TextBox customerPhone;
        private Button button1;
        private Label label5;
        private Button button6;
        private Label errorLabel;
    }
}