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
            errorLabel = new Label();
            SuspendLayout();
            // 
            // ID_textbox
            // 
            ID_textbox.BackColor = SystemColors.Control;
            ID_textbox.Location = new Point(343, 217);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Size = new Size(265, 27);
            ID_textbox.TabIndex = 1;
            ID_textbox.TextChanged += ID_textbox_TextChanged;
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.Control;
            signinButton.Font = new Font("Corbel", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            signinButton.ForeColor = Color.DarkSlateGray;
            signinButton.Location = new Point(323, 344);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(112, 57);
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
            label3.Location = new Point(256, 47);
            label3.Name = "label3";
            label3.Size = new Size(329, 58);
            label3.TabIndex = 11;
            label3.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(142, 208);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 12;
            label1.Text = "Enter Your ID:";
            // 
            // button6
            // 
            button6.Location = new Point(14, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
            button6.TabIndex = 22;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Maroon;
            errorLabel.Location = new Point(323, 422);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 23);
            errorLabel.TabIndex = 23;
            // 
            // employee_signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 451);
            Controls.Add(errorLabel);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(signinButton);
            Controls.Add(ID_textbox);
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
        private Label errorLabel;
    }
}