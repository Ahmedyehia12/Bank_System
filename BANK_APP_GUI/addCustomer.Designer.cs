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
            label1 = new Label();
            label2 = new Label();
            customerPhone = new TextBox();
            label3 = new Label();
            customerAddress = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.Location = new Point(12, 68);
            customerName.Name = "customerName";
            customerName.Size = new Size(207, 27);
            customerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(202, 23);
            label1.TabIndex = 1;
            label1.Text = "Enter Customer's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 128);
            label2.Name = "label2";
            label2.Size = new Size(204, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter Customer's Phone:";
            // 
            // customerPhone
            // 
            customerPhone.Location = new Point(12, 154);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(207, 27);
            customerPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 218);
            label3.Name = "label3";
            label3.Size = new Size(219, 23);
            label3.TabIndex = 4;
            label3.Text = "Enter Customer's Address:";
            // 
            // customerAddress
            // 
            customerAddress.Location = new Point(12, 254);
            customerAddress.Name = "customerAddress";
            customerAddress.Size = new Size(207, 27);
            customerAddress.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(310, 313);
            button1.Name = "button1";
            button1.Size = new Size(136, 49);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 374);
            Controls.Add(button1);
            Controls.Add(customerAddress);
            Controls.Add(label3);
            Controls.Add(customerPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerName);
            Name = "addCustomer";
            Text = "addCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerName;
        private Label label1;
        private Label label2;
        private TextBox customerPhone;
        private Label label3;
        private TextBox customerAddress;
        private Button button1;
    }
}