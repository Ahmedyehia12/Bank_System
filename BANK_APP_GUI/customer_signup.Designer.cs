namespace BANK_APP_GUI
{
    partial class customer_signup
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
            name = new TextBox();
            address = new TextBox();
            phone = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            accountType = new Label();
            button1 = new Button();
            button6 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(174, 202);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 0;
            label1.Text = "Enter your address:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(174, 161);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(174, 242);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 2;
            label3.Text = "Enter your phone:";
            // 
            // name
            // 
            name.Location = new Point(302, 155);
            name.Name = "name";
            name.Size = new Size(256, 23);
            name.TabIndex = 3;
            name.TextChanged += textBox1_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(302, 196);
            address.Name = "address";
            address.Size = new Size(256, 23);
            address.TabIndex = 4;
            address.TextChanged += textBox2_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(302, 239);
            phone.Name = "phone";
            phone.Size = new Size(256, 23);
            phone.TabIndex = 5;
            phone.TextChanged += textBox3_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(302, 290);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Savings";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(388, 290);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fixed Depisot";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Location = new Point(512, 290);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Salary";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // accountType
            // 
            accountType.AutoSize = true;
            accountType.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountType.ForeColor = SystemColors.Control;
            accountType.Location = new Point(174, 292);
            accountType.Name = "accountType";
            accountType.Size = new Size(87, 17);
            accountType.TabIndex = 9;
            accountType.Text = "Account Type:";
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(357, 347);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 10;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(10, 10);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 19;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(138, 48);
            label6.Name = "label6";
            label6.Size = new Size(515, 45);
            label6.TabIndex = 21;
            label6.Text = "Welcome to our banking system";
            // 
            // customer_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(accountType);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(phone);
            Controls.Add(address);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customer_signup";
            Text = "Customer Sign-Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox address;
        private TextBox phone;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label accountType;
        private Button button1;
        private Button button6;
        private Label label6;
    }
}