namespace BANK_APP_GUI
{
    partial class customerSignin
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
            customerSSN = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button6 = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(281, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(182, 253);
            label2.Name = "label2";
            label2.Size = new Size(214, 37);
            label2.TabIndex = 1;
            label2.Text = "Enter Your SSN:";
            // 
            // customerSSN
            // 
            customerSSN.Location = new Point(417, 261);
            customerSSN.Name = "customerSSN";
            customerSSN.Size = new Size(209, 27);
            customerSSN.TabIndex = 2;
            customerSSN.TextChanged += customerSSN_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(381, 453);
            button1.Name = "button1";
            button1.Size = new Size(104, 48);
            button1.TabIndex = 3;
            button1.Text = "sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(296, 76);
            label3.Name = "label3";
            label3.Size = new Size(329, 58);
            label3.TabIndex = 12;
            label3.Text = "Welcome Back!";
            // 
            // button6
            // 
            button6.Location = new Point(14, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
            button6.TabIndex = 17;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Maroon;
            errorLabel.Location = new Point(363, 557);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 23);
            errorLabel.TabIndex = 18;
            // 
            // customerSignin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(915, 600);
            Controls.Add(errorLabel);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(customerSSN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customerSignin";
            Text = "customerSignin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox customerSSN;
        private Button button1;
        private Label label3;
        private Button button6;
        private Label errorLabel;
    }
}