namespace BANK_APP_GUI
{
    partial class customerInterface
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(407, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome to our Bank ! What do you want to do ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 1;
            label2.Text = "Request Loan";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 148);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 2;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customerInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 253);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customerInterface";
            Text = "customerInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;

    }
}