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
            name = new TextBox();
            branchNum = new TextBox();
            Address = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 168);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 172);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 241);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 2;
            label3.Text = "Enter the branch number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(206, 321);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 3;
            label4.Text = "Enter your Address:";
            // 
            // name
            // 
            name.Location = new Point(421, 171);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(222, 27);
            name.TabIndex = 4;
            // 
            // branchNum
            // 
            branchNum.Location = new Point(421, 240);
            branchNum.Margin = new Padding(3, 4, 3, 4);
            branchNum.Name = "branchNum";
            branchNum.Size = new Size(222, 27);
            branchNum.TabIndex = 5;
            // 
            // Address
            // 
            Address.Location = new Point(421, 320);
            Address.Margin = new Padding(3, 4, 3, 4);
            Address.Name = "Address";
            Address.Size = new Size(222, 27);
            Address.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(279, 80);
            label5.Name = "label5";
            label5.Size = new Size(278, 24);
            label5.TabIndex = 7;
            label5.Text = "Welcome to our banking system";
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(296, 416);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(98, 41);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(483, 416);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(98, 41);
            button1.TabIndex = 13;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // employee_signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(Address);
            Controls.Add(branchNum);
            Controls.Add(name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox name;
        private TextBox branchNum;
        private TextBox Address;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}