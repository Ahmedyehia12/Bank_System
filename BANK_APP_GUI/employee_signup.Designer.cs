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
            button1 = new Button();
            button6 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 201);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(219, 205);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 1;
            label2.Text = "Enter your name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(219, 275);
            label3.Name = "label3";
            label3.Size = new Size(208, 23);
            label3.TabIndex = 2;
            label3.Text = "Enter the branch number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(221, 355);
            label4.Name = "label4";
            label4.Size = new Size(163, 23);
            label4.TabIndex = 3;
            label4.Text = "Enter your Address:";
            // 
            // name
            // 
            name.Location = new Point(435, 204);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(222, 27);
            name.TabIndex = 4;
            // 
            // branchNum
            // 
            branchNum.Location = new Point(435, 273);
            branchNum.Margin = new Padding(3, 4, 3, 4);
            branchNum.Name = "branchNum";
            branchNum.Size = new Size(222, 27);
            branchNum.TabIndex = 5;
            branchNum.TextChanged += branchNum_TextChanged;
            // 
            // Address
            // 
            Address.Location = new Point(435, 353);
            Address.Margin = new Padding(3, 4, 3, 4);
            Address.Name = "Address";
            Address.Size = new Size(222, 27);
            Address.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(376, 451);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(104, 48);
            button1.TabIndex = 13;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(11, 13);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
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
            label6.Location = new Point(177, 72);
            label6.Name = "label6";
            label6.Size = new Size(656, 58);
            label6.TabIndex = 20;
            label6.Text = "Welcome to our banking system";
            // 
            // employee_signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(914, 600);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button1);
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
        private Button button1;
        private Button button6;
        private Label label6;
    }
}