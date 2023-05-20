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
            label1 = new Label();
            ID_textbox = new TextBox();
            label2 = new Label();
            signinButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Tag = "Welcome Back!";
            label1.Text = "Welcome Back!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // ID_textbox
            // 
            ID_textbox.Location = new Point(10, 152);
            ID_textbox.Name = "ID_textbox";
            ID_textbox.Size = new Size(265, 27);
            ID_textbox.TabIndex = 1;
            ID_textbox.TextChanged += ID_textbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 119);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Your ID:";
            // 
            // signinButton
            // 
            signinButton.BackColor = SystemColors.ControlDark;
            signinButton.Location = new Point(10, 245);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(234, 63);
            signinButton.TabIndex = 3;
            signinButton.Text = "Sign in!";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signinButton);
            Controls.Add(label2);
            Controls.Add(ID_textbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Signin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ID_textbox;
        private Label label2;
        private Button signinButton;
    }
}