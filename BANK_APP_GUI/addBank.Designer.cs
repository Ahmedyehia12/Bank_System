﻿namespace BANK_APP_GUI
{
    partial class addBank
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
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            errorLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.Font = new Font("Corbel", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(337, 91);
            label2.Name = "label2";
            label2.Size = new Size(216, 58);
            label2.TabIndex = 3;
            label2.Text = "Add Bank";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(400, 360);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(234, 253);
            label3.Name = "label3";
            label3.Size = new Size(139, 29);
            label3.TabIndex = 6;
            label3.Text = "Bank Name:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(234, 360);
            label1.Name = "label1";
            label1.Size = new Size(160, 29);
            label1.TabIndex = 7;
            label1.Text = "Bank Address:";
            // 
            // button6
            // 
            button6.Location = new Point(14, 16);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(67, 35);
            button6.TabIndex = 11;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(400, 257);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button2
            // 
            button2.Location = new Point(833, 549);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(67, 35);
            button2.TabIndex = 20;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Maroon;
            errorLabel.Location = new Point(400, 556);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 23);
            errorLabel.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(415, 473);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // addBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(errorLabel);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "addBank";
            Text = "Add a New Bank";
            Load += addBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private Button button6;
        private TextBox textBox1;
        private Button button2;
        private Label errorLabel;
        private Button button1;
    }
}