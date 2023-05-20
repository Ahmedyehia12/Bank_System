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
            label5 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 228);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter your address:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 173);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(194, 281);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 2;
            label3.Text = "Enter your phone:";
            // 
            // name
            // 
            name.Location = new Point(341, 165);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(292, 27);
            name.TabIndex = 3;
            name.TextChanged += textBox1_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(341, 220);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Name = "address";
            address.Size = new Size(292, 27);
            address.TabIndex = 4;
            address.TextChanged += textBox2_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(341, 277);
            phone.Margin = new Padding(3, 4, 3, 4);
            phone.Name = "phone";
            phone.Size = new Size(292, 27);
            phone.TabIndex = 5;
            phone.TextChanged += textBox3_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(341, 345);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Savings";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(439, 345);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(121, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fixed Depisot";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(581, 345);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Salary";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // accountType
            // 
            accountType.AutoSize = true;
            accountType.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            accountType.Location = new Point(185, 348);
            accountType.Name = "accountType";
            accountType.Size = new Size(108, 21);
            accountType.TabIndex = 9;
            accountType.Text = "Account Type:";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(403, 422);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 10;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(266, 59);
            label5.Name = "label5";
            label5.Size = new Size(392, 36);
            label5.TabIndex = 12;
            label5.Text = "Welcome to our banking system";
            label5.Click += label5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 13);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
            button6.TabIndex = 19;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // customer_signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button6);
            Controls.Add(label5);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label5;
        private Button button6;
    }
}