namespace BANK_APP_GUI
{
    partial class employee_signup
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
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 126);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 129);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(179, 181);
            label3.Name = "label3";
            label3.Size = new Size(166, 18);
            label3.TabIndex = 2;
            label3.Text = "Enter the branch number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(180, 241);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 3;
            label4.Text = "Enter your Address:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(368, 240);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(244, 60);
            label5.Name = "label5";
            label5.Size = new Size(278, 24);
            label5.TabIndex = 7;
            label5.Text = "Welcome to our banking system";
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(259, 312);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(423, 312);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 13;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // employee_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "employee_signup";
            Text = "Employee Sign-Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}