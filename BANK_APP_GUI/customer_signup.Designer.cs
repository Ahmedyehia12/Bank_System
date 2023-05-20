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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 171);
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
            label2.Location = new Point(170, 130);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(170, 211);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 2;
            label3.Text = "Enter your phone:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(298, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(298, 259);
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
            radioButton2.Location = new Point(384, 259);
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
            radioButton3.Location = new Point(508, 259);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Salary";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(162, 261);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 9;
            label4.Text = "Account Type:";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(403, 319);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 10;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(248, 319);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 11;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(233, 44);
            label5.Name = "label5";
            label5.Size = new Size(308, 28);
            label5.TabIndex = 12;
            label5.Text = "Welcome to our banking system";
            label5.Click += label5_Click;
            // 
            // customer_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}