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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 7);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(159, 190);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 1;
            label2.Text = "Enter Your SSN:";
            // 
            // customerSSN
            // 
            customerSSN.Location = new Point(365, 196);
            customerSSN.Margin = new Padding(3, 2, 3, 2);
            customerSSN.Name = "customerSSN";
            customerSSN.Size = new Size(183, 23);
            customerSSN.TabIndex = 2;
            customerSSN.TextChanged += customerSSN_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(333, 340);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
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
            label3.Location = new Point(259, 57);
            label3.Name = "label3";
            label3.Size = new Size(260, 45);
            label3.TabIndex = 12;
            label3.Text = "Welcome Back!";
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 17;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // customerSignin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(801, 450);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(customerSSN);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}