namespace BANK_APP_GUI
{
    partial class employee_signin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ID_textbox = new TextBox();
            signinButton = new Button();
            label3 = new Label();
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // ID_textbox
            // 
            ID_textbox.BackColor = SystemColors.Control;
            ID_textbox.Location = new Point(300, 163);
            ID_textbox.Margin = new Padding(3, 2, 3, 2);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Size = new Size(232, 23);
            ID_textbox.TabIndex = 1;
            ID_textbox.TextChanged += ID_textbox_TextChanged;
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.Control;
            signinButton.Font = new Font("Corbel", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            signinButton.ForeColor = Color.DarkSlateGray;
            signinButton.Location = new Point(283, 258);
            signinButton.Margin = new Padding(3, 2, 3, 2);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(98, 43);
            signinButton.TabIndex = 3;
            signinButton.Text = "Sign in!";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(224, 35);
            label3.Name = "label3";
            label3.Size = new Size(260, 45);
            label3.TabIndex = 11;
            label3.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(124, 156);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 12;
            label1.Text = "Enter Your ID:";
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 22;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // employee_signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(700, 338);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(signinButton);
            Controls.Add(ID_textbox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "employee_signin";
            Text = "Signin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ID_textbox;
        private Button signinButton;
        private Label label3;
        private Label label1;
        private Button button6;
    }
}