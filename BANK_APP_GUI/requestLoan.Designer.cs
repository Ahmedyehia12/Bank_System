namespace BANK_APP_GUI
{
    partial class requestLoan
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            customerBranch = new TextBox();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            customerAccount = new TextBox();
            label5 = new Label();
            amount = new TextBox();
            button1 = new Button();
            label6 = new Label();
            loanType = new TextBox();
            button2 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(349, 116);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(28, 47);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 1;
            label1.Text = "Your Branches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(187, 255);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 2;
            label2.Text = "Choose Branch:";
            // 
            // customerBranch
            // 
            customerBranch.Location = new Point(323, 251);
            customerBranch.Margin = new Padding(3, 2, 3, 2);
            customerBranch.Name = "customerBranch";
            customerBranch.Size = new Size(168, 23);
            customerBranch.TabIndex = 3;
            customerBranch.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(423, 78);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(400, 116);
            dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(423, 47);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 5;
            label3.Text = "Your Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(187, 296);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 6;
            label4.Text = "Choose Account";
            // 
            // customerAccount
            // 
            customerAccount.Location = new Point(323, 292);
            customerAccount.Margin = new Padding(3, 2, 3, 2);
            customerAccount.Name = "customerAccount";
            customerAccount.Size = new Size(168, 23);
            customerAccount.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(188, 377);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 8;
            label5.Text = "Enter Amount:";
            // 
            // amount
            // 
            amount.Location = new Point(324, 373);
            amount.Margin = new Padding(3, 2, 3, 2);
            amount.Name = "amount";
            amount.Size = new Size(169, 23);
            amount.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(335, 443);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 40);
            button1.TabIndex = 10;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(188, 336);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 11;
            label6.Text = "Enter Loan Type";
            // 
            // loanType
            // 
            loanType.Location = new Point(324, 332);
            loanType.Margin = new Padding(3, 2, 3, 2);
            loanType.Name = "loanType";
            loanType.Size = new Size(168, 23);
            loanType.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(770, 470);
            button2.Name = "button2";
            button2.Size = new Size(59, 26);
            button2.TabIndex = 20;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 12);
            button6.Name = "button6";
            button6.Size = new Size(59, 26);
            button6.TabIndex = 21;
            button6.Text = "<-Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // requestLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(841, 508);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(loanType);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(amount);
            Controls.Add(label5);
            Controls.Add(customerAccount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(customerBranch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "requestLoan";
            Text = "requestLoan";
            Load += requestLoan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox customerBranch;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
        private TextBox customerAccount;
        private Label label5;
        private TextBox amount;
        private Button button1;
        private Label label6;
        private TextBox loanType;
        private Button button2;
        private Button button6;
    }
}