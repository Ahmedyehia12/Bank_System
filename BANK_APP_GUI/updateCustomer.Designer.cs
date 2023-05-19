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
            SuspendLayout();
            // 
            // customerSSN
            // 
            customerSSN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            customerSSN.Location = new Point(13, 60);
            customerSSN.Name = "customerSSN";
            customerSSN.Size = new Size(201, 30);
            customerSSN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 1;
            label1.Text = "Enter Customer's SSN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(237, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer's new name:";
            // 
            // newName
            // 
            newName.Location = new Point(13, 144);
            newName.Name = "newName";
            newName.Size = new Size(212, 27);
            newName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 195);
            label3.Name = "label3";
            label3.Size = new Size(257, 23);
            label3.TabIndex = 4;
            label3.Text = "Enter Customer's new Address:";
            // 
            // customerAddress
            // 
            customerAddress.Location = new Point(13, 221);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(218, 27);
            customerAddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 271);
            label4.Name = "label4";
            label4.Size = new Size(237, 23);
            label4.TabIndex = 6;
            label4.Text = "Enter Customer's new Phone";
            // 
            // customerPhone
            // 
            customerPhone.Location = new Point(13, 297);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(218, 27);
            customerPhone.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(286, 370);
            button1.Name = "button1";
            button1.Size = new Size(158, 56);
            button1.TabIndex = 8;
            button1.Text = "Update Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // updateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(customerPhone);
            Controls.Add(label4);
            Controls.Add(customerAddress);
            Controls.Add(label3);
            Controls.Add(newName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerSSN);
            Name = "updateCustomer";
            Text = "updateCustomer";
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
    }
}