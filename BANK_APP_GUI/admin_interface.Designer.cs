namespace BANK_APP_GUI
{
    partial class admin_interface
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
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(402, 140);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(250, 60);
            label2.Name = "label2";
            label2.Size = new Size(273, 45);
            label2.TabIndex = 2;
            label2.Text = "Welcome Admin";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(150, 199);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Add Bank";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(150, 161);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 4;
            label3.Text = "Adding Operation:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 232);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 5;
            button2.Text = "Add Branch";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(150, 287);
            label4.Name = "label4";
            label4.Size = new Size(201, 23);
            label4.TabIndex = 6;
            label4.Text = "Displaying Information:";
            label4.Click += label4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(150, 324);
            button3.Name = "button3";
            button3.Size = new Size(220, 23);
            button3.TabIndex = 7;
            button3.Text = "Display All Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(150, 358);
            button4.Name = "button4";
            button4.Size = new Size(220, 23);
            button4.TabIndex = 8;
            button4.Text = "Display All Loans [Detailed]";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(150, 393);
            button5.Name = "button5";
            button5.Size = new Size(220, 23);
            button5.TabIndex = 9;
            button5.Text = "Display Loans [Customer & Empolyee]";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 10;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // admin_interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_interface";
            RightToLeftLayout = true;
            Text = "Admin Interface";
            Load += admin_interface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}